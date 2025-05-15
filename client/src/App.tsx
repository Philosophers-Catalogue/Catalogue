import { Route, Routes } from "react-router-dom";
import { MainLayout } from "./pages/Layout";
import { LoginPage } from "./pages/Login";
import RegisterPage from "./pages/Register";
import { CssBaseline, ThemeProvider } from "@mui/material";
import theme from "./theme";
import { HomePage } from "./pages/HomePage";
import { RecommendationDetailPage } from "./pages/RecommendationItemPage";

function App() {
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Routes>
        <Route element={<MainLayout />}>
          <Route path="/item/:id" element={<RecommendationDetailPage />} />
          <Route path="/" element={<HomePage />} />
          <Route path="/login" element={<LoginPage />} />
          <Route path="/register" element={<RegisterPage />} />
        </Route>
      </Routes>
    </ThemeProvider>
  );
}

export default App;
