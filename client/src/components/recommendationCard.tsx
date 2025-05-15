import React from "react";
import { Card, CardContent, Typography, CardActionArea } from "@mui/material";
import { RecommendationItem } from "../types/recommendationTypes"; // Путь к вашему файлу с типами
import { useNavigate } from "react-router-dom";

interface RecommendationCardProps {
  item: RecommendationItem;
}

export const RecommendationCard: React.FC<RecommendationCardProps> = ({
  item,
}) => {
  const navigate = useNavigate();

  const handleCardClick = () => {
    navigate(`/item/${item.id}`);
  };
  return (
    <Card
      sx={{
        height: "180px",
        display: "flex",
        flexDirection: "column",
      }}
    >
      <CardActionArea
        onClick={handleCardClick}
        sx={{
          flexGrow: 1,
          display: "flex",
          flexDirection: "column",
          alignItems: "flex-start",
        }}
      >
        {/* Если у вас есть imageUrl, можно добавить CardMedia сюда */}
        <CardContent sx={{ width: "100%" }}>
          <Typography gutterBottom variant="h5" component="div">
            {item.title}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {item.description}
          </Typography>
        </CardContent>
      </CardActionArea>
      {/* Можно добавить CardActions для кнопок, если нужно прямо на карточке */}
    </Card>
  );
};
