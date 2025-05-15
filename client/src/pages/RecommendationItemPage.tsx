// src/pages/RecommendationDetailPage.tsx
import "./RecommendationItemPage.css";
import React, { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import {
  Container,
  Typography,
  Box,
  Paper,
  Button,
  IconButton,
  CircularProgress,
  Alert,
  Stack,
} from "@mui/material";
import ThumbUpAltIcon from "@mui/icons-material/ThumbUpAlt";
import ThumbDownAltIcon from "@mui/icons-material/ThumbDownAlt";
import ArrowBackIcon from "@mui/icons-material/ArrowBack";
import { RecommendationItem } from "../types/recommendationTypes";
import { useAppStore } from "../components/appStore";
import { mockRecommendations } from "./HomePage";
import { RecommendationCard } from "../components/recommendationCard";

import Slider from "react-slick"; // Импорт для карусели
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

// Заглушка для API-вызова или поиска элемента в существующем списке
// В реальном приложении здесь будет запрос к бэкенду
const fetchRecommendationById = async (
  id: string
): Promise<RecommendationItem | null> => {
  return new Promise((resolve) => {
    setTimeout(() => {
      const item = mockRecommendations.find((r) => r.id.toString() === id);
      resolve(item || null);
    }, 500);
  });
};

export const RecommendationDetailPage: React.FC = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [item, setItem] = useState<RecommendationItem | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const isAuthenticated = useAppStore((state) => state.isSignUp);

  const [recommendationsForCarousel, setRecommendationsForCarousel] = useState<
    RecommendationItem[]
  >([]);
  const [userVote, setUserVote] = useState<"like" | "dislike" | null>(null); // 'like', 'dislike', or null

  useEffect(() => {
    if (!id) {
      setError("Идентификатор рекомендации отсутствует.");
      setLoading(false);
      return;
    }

    const loadItem = async () => {
      setLoading(true);
      setError(null);
      try {
        const fetchedItem = await fetchRecommendationById(id);
        if (fetchedItem) {
          setItem(fetchedItem);
          const carouselData = mockRecommendations.filter(
            (rec) => rec.id.toString() !== id
          );
          setRecommendationsForCarousel(carouselData);
        } else {
          setError("Рекомендация не найдена.");
        }
      } catch (e) {
        console.error(e);
        setError("Ошибка при загрузке данных.");
      } finally {
        setLoading(false);
      }
    };

    loadItem();
  }, [id]);

  const handleLike = () => {
    if (!isAuthenticated) return;
    console.log("Liked item:", id);
    if (userVote === "like") {
      setUserVote(null);
    } else {
      setUserVote("like");
    }
  };

  const handleDislike = () => {
    if (!isAuthenticated) return;
    console.log("Disliked item:", id);
    if (userVote === "dislike") {
      setUserVote(null);
    } else {
      setUserVote("dislike");
    }
  };

  const carouselSettings = {
    dots: true,
    infinite: recommendationsForCarousel.length > 3,
    speed: 500,
    slidesToShow: Math.min(3, recommendationsForCarousel.length),
    slidesToScroll: 1,
    autoplay: true,
    autoplaySpeed: 3000,
    pauseOnHover: true,
    responsive: [
      {
        breakpoint: 1024, // для md экранов
        settings: {
          slidesToShow: Math.min(2, recommendationsForCarousel.length),
          infinite: recommendationsForCarousel.length > 2,
        },
      },
      {
        breakpoint: 600, // для sm экранов
        settings: {
          slidesToShow: 1,
          infinite: recommendationsForCarousel.length > 1,
        },
      },
    ],
  };

  if (loading) {
    return (
      <Box
        sx={{
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
          minHeight: "60vh",
        }}
      >
        <CircularProgress />
      </Box>
    );
  }

  if (error) {
    return (
      <Container maxWidth="md" sx={{ py: 3 }}>
        <Alert severity="error">{error}</Alert>
        <Button
          startIcon={<ArrowBackIcon />}
          onClick={() => navigate(-1)}
          sx={{ mt: 2 }}
        >
          Назад
        </Button>
      </Container>
    );
  }

  if (!item) {
    // Это состояние не должно достигаться, если error обработан, но на всякий случай
    return <Typography>Элемент не найден.</Typography>;
  }

  return (
    <Container maxWidth="md" sx={{ pb: 35 }}>
      <Button
        startIcon={<ArrowBackIcon />}
        onClick={() => navigate(-1)}
        sx={{ mb: 2, fontSize: "20px" }}
      >
        Назад к списку
      </Button>
      <Paper elevation={3} sx={{ p: { xs: 2, sm: 3, md: 4 } }}>
        <Typography variant="h3" component="h1" gutterBottom>
          {item.title}
        </Typography>
        {/* Здесь можно добавить дату публикации, автора, теги и т.д., если они есть */}
        {/* <Typography variant="caption" color="text.secondary" gutterBottom>
          Опубликовано: {new Date().toLocaleDateString()}
        </Typography> */}

        <Typography variant="body1" sx={{ my: 3, whiteSpace: "pre-line" }}>
          {item.description}
        </Typography>

        {/* Разделитель */}
        {/* <Divider sx={{ my: 3 }} /> */}

        {isAuthenticated && (
          <Box sx={{ mt: 4, display: "flex", alignItems: "center", gap: 2 }}>
            <Stack direction="row" spacing={1} alignItems="center">
              <IconButton
                color={userVote === "like" ? "primary" : "default"}
                onClick={handleLike}
                aria-label="like"
              >
                <ThumbUpAltIcon />
              </IconButton>
            </Stack>

            <Stack direction="row" spacing={1} alignItems="center">
              <IconButton
                color={userVote === "dislike" ? "secondary" : "default"}
                onClick={handleDislike}
                aria-label="dislike"
              >
                <ThumbDownAltIcon />
              </IconButton>
            </Stack>
          </Box>
        )}
      </Paper>

      {/* Условное отображение карусели */}
      {isAuthenticated &&
        userVote === "like" &&
        recommendationsForCarousel.length > 0 && (
          <Box sx={{ mt: 4 }}>
            {" "}
            {/* Отступ сверху для секции карусели */}
            <Typography variant="h5" component="h2" gutterBottom sx={{ mb: 2 }}>
              Похожие рекомендации:
            </Typography>
            {/* Обертка для исправления проблемы с шириной в react-slick при использовании Material UI Grid/Box.
            Или можно настроить padding непосредственно в Slider или в дочерних элементах.
          */}
            <Box sx={{ mx: -1 }}>
              {" "}
              {/* Небольшой отрицательный margin для компенсации padding на слайдах */}
              <Slider {...carouselSettings}>
                {recommendationsForCarousel.map((recItem) => (
                  <Box key={recItem.id} sx={{ p: 1 }}>
                    {" "}
                    <RecommendationCard item={recItem} />
                  </Box>
                ))}
              </Slider>
            </Box>
          </Box>
        )}
    </Container>
  );
};
