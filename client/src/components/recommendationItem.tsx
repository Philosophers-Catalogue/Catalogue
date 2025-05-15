import React from "react";
import { Card, CardContent, Typography, Box } from "@mui/material";
import { RecommendationItem } from "../types/recommendationTypes"; // Путь к вашему файлу с типами

interface RecommendationCardProps {
  item: RecommendationItem;
}

export const RecommendationCard: React.FC<RecommendationCardProps> = ({
  item,
}) => {
  return (
    <Card
      sx={{ height: "100%", display: "flex", flexDirection: "column" }}
      onClick={() => {}}
    >
      <CardContent sx={{ flexGrow: 1 }}>
        <Typography gutterBottom variant="h5" component="div">
          {item.title}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {item.description}
        </Typography>
      </CardContent>
    </Card>
  );
};
