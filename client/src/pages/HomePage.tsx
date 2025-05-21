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
import { RecommendationCard } from "../components/recommendationCard";
import SearchIcon from "@mui/icons-material/Search";

export interface RecommendationItem {
  id: string;
  title: string;
  description: string;
  category:
    | "Направление"
    | "Категориальная школа"
    | "Философ"
    | "Работа"
    | "Понятие";
}

const recommendedItems: Omit<RecommendationItem, "category">[] = [
  {
    id: "r1",
    title: "Фридрих Ницше",
    description:
      "Немецкий философ, автор идеи 'воли к власти' и критик морали.",
  },
  {
    id: "r2",
    title: "Так говорил Заратустра",
    description:
      "Философское произведение Ницше, наполненное афоризмами и метафорами.",
  },
  {
    id: "r3",
    title: "Антихрист",
    description: "Резкая критика христианской морали от Ницше.",
  },
  {
    id: "r4",
    title: "Воля к власти",
    description: "Сборник идей Ницше о движущей силе человека.",
  },
  {
    id: "r5",
    title: "Дионсийский и аполлоновский начала",
    description: "Ключевые эстетические категории в философии Ницше.",
  },
  {
    id: "r6",
    title: "Переоценка всех ценностей",
    description: "Критика традиционных моральных и философских норм.",
  },
  {
    id: "r7",
    title: "Ницше и экзистенциализм",
    description: "Влияние Ницше на экзистенциалистскую традицию.",
  },
  {
    id: "r8",
    title: "Ницше и психология",
    description: "Предвосхищение идей Фрейда и Юнга.",
  },
  {
    id: "r9",
    title: "Ницше и постмодерн",
    description: "Влияние идей Ницше на постмодернистскую философию.",
  },
  {
    id: "r10",
    title: "Философия молота",
    description: "Метод Ницше для разрушения традиционных ценностей.",
  },
];

export const mockRecommendations: RecommendationItem[] = [
  // Направление
  {
    id: "1",
    title: "Экзистенциализм",
    description: "О свободе и ответственности в трудах Сартра, Камю.",
    category: "Направление",
  },
  {
    id: "2",
    title: "Стоицизм",
    description: "О принятии, добродетели и разуме.",
    category: "Направление",
  },
  {
    id: "3",
    title: "Позитивизм",
    description: "Научное знание как единственно достоверное.",
    category: "Направление",
  },
  {
    id: "4",
    title: "Скептицизм",
    description: "Сомнение как метод.",
    category: "Направление",
  },
  {
    id: "5",
    title: "Материализм",
    description: "Материя как основа бытия.",
    category: "Направление",
  },
  {
    id: "6",
    title: "Рационализм",
    description: "Разум как источник знания.",
    category: "Направление",
  },
  {
    id: "7",
    title: "Идеализм",
    description: "Первичность сознания над материей.",
    category: "Направление",
  },
  {
    id: "8",
    title: "Герменевтика",
    description: "Искусство интерпретации.",
    category: "Направление",
  },
  {
    id: "9",
    title: "Феноменология",
    description: "Сознательный опыт как основа познания.",
    category: "Направление",
  },
  {
    id: "10",
    title: "Прагматизм",
    description: "Истина как то, что работает.",
    category: "Направление",
  },

  // Категориальная школа
  {
    id: "11",
    title: "Классическая",
    description: "Школа Аристотеля и Платона.",
    category: "Категориальная школа",
  },
  {
    id: "12",
    title: "Средневековая",
    description: "Схоластика, Фома Аквинский.",
    category: "Категориальная школа",
  },
  {
    id: "13",
    title: "Новое время",
    description: "Декарт, Лейбниц, Спиноза.",
    category: "Категориальная школа",
  },
  {
    id: "14",
    title: "Немецкая классика",
    description: "Кант, Гегель, Фихте.",
    category: "Категориальная школа",
  },
  {
    id: "15",
    title: "Франкфуртская школа",
    description: "Критическая теория.",
    category: "Категориальная школа",
  },
  {
    id: "16",
    title: "Аналитическая философия",
    description: "Логика и язык.",
    category: "Категориальная школа",
  },
  {
    id: "17",
    title: "Постструктурализм",
    description: "Фуко, Деррида.",
    category: "Категориальная школа",
  },
  {
    id: "18",
    title: "Экзистенциализм",
    description: "Философия выбора.",
    category: "Категориальная школа",
  },
  {
    id: "19",
    title: "Феноменология",
    description: "Гуссерль, Мерло-Понти.",
    category: "Категориальная школа",
  },
  {
    id: "20",
    title: "Восточная философия",
    description: "Даосизм, конфуцианство.",
    category: "Категориальная школа",
  },

  // Философ
  {
    id: "21",
    title: "Платон",
    description: "Автор идейной теории форм.",
    category: "Философ",
  },
  {
    id: "22",
    title: "Аристотель",
    description: "Создатель формальной логики.",
    category: "Философ",
  },
  {
    id: "23",
    title: "Кант",
    description: "Трансцендентальный идеализм.",
    category: "Философ",
  },
  {
    id: "24",
    title: "Гегель",
    description: "Диалектика и абсолютный дух.",
    category: "Философ",
  },
  {
    id: "25",
    title: "Сартр",
    description: "Экзистенциализм и свобода.",
    category: "Философ",
  },
  {
    id: "26",
    title: "Камю",
    description: "Абсурд и бунт.",
    category: "Философ",
  },
  {
    id: "27",
    title: "Фуко",
    description: "Власть и знание.",
    category: "Философ",
  },
  {
    id: "28",
    title: "Ницше",
    description: "Сверхчеловек и воля к власти.",
    category: "Философ",
  },
  {
    id: "29",
    title: "Лао-цзы",
    description: "Дао и У-вэй.",
    category: "Философ",
  },
  {
    id: "30",
    title: "Будда",
    description: "Путь освобождения.",
    category: "Философ",
  },

  // Работа
  {
    id: "31",
    title: "Критика чистого разума",
    description: "Кант. О границах познания.",
    category: "Работа",
  },
  {
    id: "32",
    title: "Так говорил Заратустра",
    description: "Ницше о сверхчеловеке.",
    category: "Работа",
  },
  {
    id: "33",
    title: "Бытие и ничто",
    description: "Сартр. Фундамент экзистенциализма.",
    category: "Работа",
  },
  {
    id: "34",
    title: "Анти-Эдип",
    description: "Делёз и Гваттари о шизоанализе.",
    category: "Работа",
  },
  {
    id: "35",
    title: "Наказание и дисциплина",
    description: "Фуко об институтах власти.",
    category: "Работа",
  },
  {
    id: "36",
    title: "Логико-философский трактат",
    description: "Витгенштейн о языке и мире.",
    category: "Работа",
  },
  {
    id: "37",
    title: "Метафизика",
    description: "Аристотель о бытии.",
    category: "Работа",
  },
  {
    id: "38",
    title: "Республика",
    description: "Платон об идеальном государстве.",
    category: "Работа",
  },
  {
    id: "39",
    title: "Дао Дэ Цзин",
    description: "Лао-цзы о пути и добродетели.",
    category: "Работа",
  },
  {
    id: "40",
    title: "Сутра сердца",
    description: "Краткое изложение буддийской мудрости.",
    category: "Работа",
  },

  // Понятие
  {
    id: "41",
    title: "Бытие",
    description: "Основное философское понятие.",
    category: "Понятие",
  },
  {
    id: "42",
    title: "Свобода",
    description: "Связана с выбором и ответственностью.",
    category: "Понятие",
  },
  {
    id: "43",
    title: "Истина",
    description: "Соответствие реальности.",
    category: "Понятие",
  },
  {
    id: "44",
    title: "Сознание",
    description: "О субъективном опыте.",
    category: "Понятие",
  },
  {
    id: "45",
    title: "Мораль",
    description: "Система норм и ценностей.",
    category: "Понятие",
  },
  {
    id: "46",
    title: "Абсурд",
    description: "Отсутствие смысла.",
    category: "Понятие",
  },
  {
    id: "47",
    title: "Знание",
    description: "Обоснованное истинное убеждение.",
    category: "Понятие",
  },
  {
    id: "48",
    title: "Справедливость",
    description: "Этическая категория.",
    category: "Понятие",
  },
  {
    id: "49",
    title: "Сущность",
    description: "То, что делает вещь тем, чем она является.",
    category: "Понятие",
  },
  {
    id: "50",
    title: "Добродетель",
    description: "Моральное совершенство.",
    category: "Понятие",
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
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    setLoading(true);
    setTimeout(() => {
      setRecommendations(mockRecommendations);
      setFilteredRecommendations(mockRecommendations);
      setLoading(false);
    }, 500);
  }, []);

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

  const groupedRandomEnities = filteredRecommendations.reduce((acc, item) => {
    if (!acc[item.category]) acc[item.category] = [];
    acc[item.category].push(item);
    return acc;
  }, {} as Record<RecommendationItem["category"], RecommendationItem[]>);

  return (
    <Container maxWidth="lg">
      <Typography
        variant="h1"
        sx={{
          my: 4,
          textAlign: "center",
          fontSize: { xs: "2rem", md: "3rem" },
        }}
      >
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
              "& fieldset": { border: "none" },
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
        <>
          <Typography variant="h2" sx={{ mb: 4 }}>
            Рекомендации
          </Typography>
          <Grid container spacing={3} sx={{ mb: 5 }} alignItems="stretch">
            {recommendedItems.map((item) => (
              <Grid size={{ xs: 12, sm: 6, md: 4 }} key={item.id}>
                <RecommendationCard item={item} />
              </Grid>
            ))}
          </Grid>
          {Object.entries(groupedRandomEnities).map(([category, items]) => (
            <Box key={category} sx={{ mb: 5 }}>
              <Typography variant="h4" sx={{ mb: 2 }}>
                {category}
              </Typography>
              <Grid container spacing={3} alignItems="stretch">
                {items.map((item) => (
                  <Grid size={{ xs: 12, sm: 6, md: 4 }} key={item.id}>
                    <RecommendationCard item={item} />
                  </Grid>
                ))}
              </Grid>
            </Box>
          ))}
        </>
      )}
    </Container>
  );
};
