import {
  Container,
  Typography,
  Paper,
  TextField,
  IconButton,
  Box,
  CircularProgress,
  Grid,
  InputAdornment,
} from "@mui/material";

import { useEffect, useState } from "react";
import { RecommendationItem } from "../types/recommendationTypes";
import { RecommendationCard } from "../components/recommendationCard";
import SearchIcon from "@mui/icons-material/Search";

export const mockRecommendations: RecommendationItem[] = [
  {
    id: "1",
    title: "Философия для начинающих",
    description:
      "Основные концепции и мыслители, которые сформировали мир философии.",
  },
  {
    id: "2",
    title: "Экзистенциализм",
    description:
      "Исследование свободы, ответственности и смысла жизни через труды Сартра, Камю и других.",
  },
  {
    id: "3",
    title: "Стоицизм в современном мире",
    description:
      "Как древние принципы стоиков могут помочь справиться с вызовами XXI века.",
  },
  {
    id: "4",
    title: "Восточная философия",
    description: "Обзор ключевых идей буддизма, даосизма и конфуцианства.",
  },
  {
    id: "5",
    title: "Этика и мораль",
    description:
      "Размышления о правильном и неправильном, добре и зле в различных философских системах.",
  },
  {
    id: "6",
    title: "Философия науки",
    description:
      "Как философия помогает понять научный метод, его возможности и ограничения.",
  },
  {
    id: "7",
    title: "Политическая философия",
    description:
      "Идеи о справедливости, власти, правах и обязанностях гражданина и государства.",
  },
  {
    id: "8",
    title: "Метафизика: за гранью физического",
    description: "Вопросы о природе реальности, бытия, времени и пространства.",
  },
];

export const HomePage: React.FC = () => {
  const [searchTerm, setSearchTerm] = useState("");
  const [recommendations, setRecommendations] = useState<RecommendationItem[]>(
    []
  );
  const [filteredRecommendations, setFilteredRecommendations] = useState<
    RecommendationItem[]
  >([]);
  const [loading, setLoading] = useState(true); // Состояние загрузки

  useEffect(() => {
    setLoading(true);
    setTimeout(() => {
      setRecommendations(mockRecommendations);
      setFilteredRecommendations(mockRecommendations);
      setLoading(false);
    }, 500);
  }, []);

  // Фильтрация по поисковому запросу
  useEffect(() => {
    const lowercasedFilter = searchTerm.toLowerCase();
    const filteredData = recommendations.filter(
      (item) =>
        item.title.toLowerCase().includes(lowercasedFilter) ||
        item.description.toLowerCase().includes(lowercasedFilter)
    );
    setFilteredRecommendations(filteredData);
  }, [searchTerm, recommendations]);

  const handleSearchChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setSearchTerm(event.target.value);
  };

  return (
    <Container maxWidth="lg">
      {" "}
      <Typography
        variant="h1"
        sx={{
          my: 4,
          textAlign: "center",
          fontSize: { xs: "2rem", md: "3rem" },
        }}
      >
        {" "}
        Философский Каталог
      </Typography>
      <Paper
        component="form"
        elevation={1}
        sx={{
          p: "2px 4px",
          display: "flex",
          alignItems: "center",
          width: "100%",
          maxWidth: "700px",
          mx: "auto",
          mb: 4,
          borderRadius: "8px",
        }}
      >
        <TextField
          fullWidth
          placeholder="Search..."
          value={searchTerm}
          onChange={handleSearchChange}
          sx={{
            height: 48,
            pb: "50px",
            "& .MuiOutlinedInput-root": {
              borderRadius: "8px 0 0 8px",
              "& fieldset": {
                border: "none",
              },
            },
          }}
          slotProps={{
            input: {
              startAdornment: (
                <InputAdornment position="start">
                  <SearchIcon />
                </InputAdornment>
              ),
            },
          }}
        />
        <IconButton
          type="submit"
          sx={{
            height: 48,
            p: "10px",
            borderRadius: "0 8px 8px 0",
            backgroundColor: "primary.main",
            color: "white",
            "&:hover": { backgroundColor: "primary.dark" },
          }}
          aria-label="search"
        >
          <SearchIcon />
        </IconButton>
      </Paper>
      {loading ? (
        <Box sx={{ display: "flex", justifyContent: "center", my: 5 }}>
          <CircularProgress />
        </Box>
      ) : (
        <Grid container spacing={3} alignItems="stretch">
          {filteredRecommendations.length > 0 ? (
            filteredRecommendations.map((item) => (
              <Grid size={{ xs: 12, sm: 6, md: 4 }} key={item.id}>
                {" "}
                <RecommendationCard item={item} />
              </Grid>
            ))
          ) : (
            <Grid size={{ xs: 12 }}>
              <Typography
                variant="subtitle1"
                sx={{ textAlign: "center", mt: 3 }}
              >
                По вашему запросу ничего не найдено.
              </Typography>
            </Grid>
          )}
        </Grid>
      )}
    </Container>
  );
};
