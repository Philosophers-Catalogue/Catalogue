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
} from "@mui/material";
import { useNavigate } from "react-router-dom";
import { RegisterRequest, register as apiRegister } from "../api/auth-api";
import { HttpValidationProblemDetails } from "../types";

type RegisterFormData = RegisterRequest;

const RegisterPage: React.FC = () => {
  const {
    control,
    handleSubmit,
    formState: { errors, isSubmitting },
    setError,
  } = useForm<RegisterFormData>({
    defaultValues: {
      email: "",
      password: "",
    },
  });
  const navigate = useNavigate();
  const [globalError, setGlobalError] = useState<string | null>(null);
  const [successMessage, setSuccessMessage] = useState<string | null>(null);

  const onSubmit: SubmitHandler<RegisterFormData> = async (data) => {
    setGlobalError(null);
    setSuccessMessage(null);
    try {
      await apiRegister(data);
      setSuccessMessage("Регистрация прошла успешно! Теперь вы можете войти.");
      // Опционально: перенаправление через несколько секунд или кнопка для перехода
      setTimeout(() => {
        navigate("/login");
      }, 3000);
    } catch (error) {
      const apiErr = error as HttpValidationProblemDetails;
      console.error("Ошибка регистрации:", apiErr);
      if (apiErr.errors) {
        // Установка ошибок для конкретных полей, если API их возвращает
        // Пример: если API возвращает { errors: { Email: ["Email already exists"] } }
        (Object.keys(apiErr.errors) as Array<keyof RegisterFormData>).forEach(
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
          setGlobalError(apiErr.title || "Произошла ошибка при регистрации.");
        }
      } else {
        setGlobalError("Произошла ошибка при регистрации.");
      }
    }
  };

  return (
    <Container maxWidth="sm">
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
          Регистрация
        </Typography>
        {globalError && (
          <Alert severity="error" sx={{ width: "100%", mb: 2 }}>
            {globalError}
          </Alert>
        )}
        {successMessage && (
          <Alert severity="success" sx={{ width: "100%", mb: 2 }}>
            {successMessage}
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
            rules={{
              required: "Пароль обязателен",
              minLength: {
                value: 6,
                message: "Пароль должен содержать не менее 6 символов",
              },
            }}
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
                autoComplete="new-password"
                error={!!errors.password}
                helperText={errors.password?.message}
              />
            )}
          />
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            disabled={isSubmitting}
            sx={{ mt: 3, mb: 2 }}
          >
            {isSubmitting ? "Регистрация..." : "Зарегистрироваться"}
          </Button>
        </Box>
      </Paper>
    </Container>
  );
};

export default RegisterPage;
