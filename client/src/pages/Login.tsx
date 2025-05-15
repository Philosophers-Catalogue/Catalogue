import React, { useState } from "react";
import { useForm, Controller, SubmitHandler } from "react-hook-form";
import {
  TextField,
  Button,
  Container,
  Typography,
  Paper,
  Box,
  Alert,
  Grid,
} from "@mui/material";
import { Link, useNavigate } from "react-router-dom";
import {
  LoginRequest,
  ApiError,
  login as apiLogin,
  AccessTokenResponse,
} from "../api/auth-api"; // Убедитесь, что путь верный

type LoginFormData = Omit<
  LoginRequest,
  "twoFactorCode" | "twoFactorRecoveryCode"
>; // Упрощаем для начала

export const LoginPage: React.FC = () => {
  const {
    control,
    handleSubmit,
    formState: { errors, isSubmitting },
    setError,
  } = useForm<LoginFormData>({
    defaultValues: {
      email: "",
      password: "",
    },
  });
  const navigate = useNavigate();
  const [globalError, setGlobalError] = useState<string | null>(null);

  // Предположим, у вас есть функция для сохранения токена (например, в AuthContext или localStorage)
  const handleLoginSuccess = (tokenResponse: AccessTokenResponse) => {
    console.log("Login successful, token:", tokenResponse.accessToken);
    localStorage.setItem("accessToken", tokenResponse.accessToken);
    localStorage.setItem("refreshToken", tokenResponse.refreshToken);
    // TODO: Обновить состояние аутентификации в приложении (например, через Context API)
    navigate("/"); // Перенаправление на главную страницу после входа
  };

  const onSubmit: SubmitHandler<LoginFormData> = async (data) => {
    setGlobalError(null);
    try {
      // Для login можно передать параметры useCookies/useSessionCookies, если нужно
      const tokenResponse = await apiLogin(data /*, { useCookies: true } */);
      handleLoginSuccess(tokenResponse);
    } catch (error) {
      const apiErr = error as ApiError;
      console.error("Ошибка входа:", apiErr);
      if ("errors" in apiErr && apiErr.errors) {
        (Object.keys(apiErr.errors) as Array<keyof LoginFormData>).forEach(
          (key) => {
            if (
              apiErr.errors &&
              apiErr.errors[key] &&
              (key === "email" || key === "password")
            ) {
              setError(key, {
                type: "server",
                message: apiErr.errors[key].join(", "),
              });
            }
          }
        );
        if (
          !Object.keys(apiErr.errors).some((k) =>
            ["email", "password"].includes(k)
          )
        ) {
          setGlobalError(apiErr.title || "Произошла ошибка при входе.");
        }
      } else if ("message" in apiErr) {
        setGlobalError(apiErr.message || "Неверный email или пароль."); // Общее сообщение
      }
    }
  };

  return (
    <Container component="main" maxWidth="sm">
      <Paper
        elevation={3}
        sx={{
          p: 4,
          mt: 8,
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
        }}
      >
        <Typography component="h1" variant="h5" sx={{ mb: 3 }}>
          Вход
        </Typography>
        {globalError && (
          <Alert severity="error" sx={{ width: "100%", mb: 2 }}>
            {globalError}
          </Alert>
        )}
        <Box
          component="form"
          onSubmit={handleSubmit(onSubmit)}
          sx={{ width: "100%" }}
        >
          <Controller
            name="email"
            control={control}
            rules={{
              required: "Email обязателен",
              pattern: {
                value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i,
                message: "Неверный формат email",
              },
            }}
            render={({ field }) => (
              <TextField
                {...field}
                margin="normal"
                required
                fullWidth
                id="email"
                label="Email"
                autoComplete="email"
                autoFocus
                error={!!errors.email}
                helperText={errors.email?.message}
              />
            )}
          />
          <Controller
            name="password"
            control={control}
            rules={{ required: "Пароль обязателен" }}
            render={({ field }) => (
              <TextField
                {...field}
                margin="normal"
                required
                fullWidth
                name="password"
                label="Пароль"
                type="password"
                id="password"
                autoComplete="current-password"
                error={!!errors.password}
                helperText={errors.password?.message}
              />
            )}
          />
          {/* TODO: Добавить поля для twoFactorCode и twoFactorRecoveryCode, если требуется */}
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            disabled={isSubmitting}
            sx={{ mt: 3, mb: 2 }}
          >
            {isSubmitting ? "Вход..." : "Войти"}
          </Button>
          <Grid>
            <Link to="/register">{"Нет аккаунта? Зарегистрируйтесь"}</Link>
          </Grid>
        </Box>
      </Paper>
    </Container>
  );
};
