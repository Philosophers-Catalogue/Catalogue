import React from "react";
import { Outlet, useNavigate } from "react-router-dom";
import {
  AppBar,
  Toolbar,
  Typography,
  Button,
  Container,
  Box,
  IconButton,
} from "@mui/material";
import { useAppStore } from "../components/appStore";

export const MainLayout: React.FC = () => {
  const navigate = useNavigate();
  const isSignUp = useAppStore((state) => state.isSignUp);

  return (
    <Box
      sx={{
        flexGrow: 1,
        display: "flex",
        flexDirection: "column",
        minHeight: "100vh",
      }}
    >
      {/* Header: full width */}
      <AppBar position="static">
        <Toolbar sx={{ justifyContent: "space-between" }}>
          <Box sx={{ display: "flex", alignItems: "center" }}>
            <IconButton
              edge="start"
              disableFocusRipple
              disableRipple
              onClick={() => navigate("/")}
            >
              <img
                src="/philosopher-logo.webp"
                alt="Logo"
                width={40}
                height={40}
              />
            </IconButton>
            <Typography variant="h6" sx={{ ml: 1 }}>
              Philosopher's Catalogue
            </Typography>
          </Box>

          {!isSignUp && (
            <Box sx={{ display: "flex", gap: 1 }}>
              <Button
                color="inherit"
                variant="outlined"
                sx={{
                  color: "primary.main",
                  borderColor: "primary.main",
                }}
                onClick={() => navigate("/login")}
              >
                Войти
              </Button>
              <Button
                variant="contained"
                color="primary"
                onClick={() => navigate("/register")}
              >
                Зарегистрироваться
              </Button>
            </Box>
          )}
        </Toolbar>
      </AppBar>

      {/* Main content: centered in a container */}
      <Box
        component="main"
        sx={{
          flexGrow: 1,
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
          px: 2,
          py: 4,
        }}
      >
        <Container maxWidth="lg">
          <Outlet />
        </Container>
      </Box>

      {/* Footer: full width */}
      <Box
        component="footer"
        sx={{ p: 2, backgroundColor: "grey.200", textAlign: "center" }}
      >
        <Typography variant="body2" color="text.secondary">
          © {new Date().getFullYear()} Philosopher-Catalogue
        </Typography>
      </Box>
    </Box>
  );
};
