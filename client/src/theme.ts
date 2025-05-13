import { createTheme } from "@mui/material";

const theme = createTheme({
  palette: {
    primary: {
      main: "#1976d2", // Синий цвет, похожий на кнопки в прототипе
    },
    secondary: {
      main: "#dc004e", // Пример вторичного цвета
    },
    background: {
      default: "#f4f6f8", // Очень светло-серый для фона страницы
      paper: "#ffffff", // Белый для элементов "бумаги" (карточки, формы)
    },
  },
  typography: {
    fontFamily: "Arial, sans-serif", // Вы можете указать здесь нужный шрифт
    h1: {
      fontSize: "2.5rem",
      fontWeight: 700,
    },
    h2: {
      fontSize: "2rem",
      fontWeight: 600,
    },
    // ... другие настройки типографии
  },
  components: {
    MuiButton: {
      styleOverrides: {
        root: {
          borderRadius: 8,
          textTransform: "none", // Чтобы текст кнопок не был в ВЕРХНЕМ РЕГИСТРЕ
        },
        containedPrimary: {
          color: "#ffffff", // Белый текст для основных кнопок
        },
      },
    },
    MuiAppBar: {
      styleOverrides: {
        root: {
          backgroundColor: "#ffffff", // Белый фон для AppBar
          color: "#000000", // Черный текст для элементов AppBar
          boxShadow: "0px 2px 4px -1px rgba(0,0,0,0.06)", // Легкая тень
        },
      },
    },
    MuiPaper: {
      styleOverrides: {
        root: {
          borderRadius: 12,
        },
      },
    },
  },
});

export default theme;
