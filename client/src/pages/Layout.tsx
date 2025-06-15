import React, { useEffect } from "react";
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
import { checkAuth, logout } from "../api/auth-api";

export const MainLayout: React.FC = () => {
  const navigate = useNavigate();
  const isAuthenticated = useAppStore((state) => state.isSignUp);
  const setIsAuthenticated = useAppStore((state) => state.setIsSignUp);

  console.log(isAuthenticated);
  useEffect(() => {
    const verifyAuth = async () => {
      try {
        const user = await checkAuth();
        setIsAuthenticated(!!user);
      } catch (error) {
        console.error(error);
        setIsAuthenticated(false);
      }
    };

    verifyAuth();
  }, [setIsAuthenticated]);

  const handleLogout = async () => {
    try {
      await logout();
      setIsAuthenticated(false);
      navigate("/login");
    } catch (error) {
      console.error("Logout failed:", error);
      // You might want to show an error message to the user
    }
  };

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

          {!isAuthenticated ? (
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
          ) : (
            <Box sx={{ display: "flex", gap: 1 }}>
              <Button
                variant="contained"
                color="primary"
                onClick={handleLogout}
              >
                Выйти
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
