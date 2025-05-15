from contextlib import asynccontextmanager
from typing import Dict, List, Optional
import uuid
from fastapi import FastAPI, HTTPException
import numpy as np
from pydantic import BaseModel
from sentence_transformers import SentenceTransformer
from sklearn.metrics.pairwise import cosine_similarity


class BaseItem(BaseModel):
    id: uuid.UUID
    name_en: str
    description_en: Optional[str] = None
    wikipedia_id: Optional[int] = None


class Philosopher(BaseItem):
    bio_en: Optional[str] = None


class Work(BaseItem):
    publication_year: Optional[int] = None
    primary_author_id: Optional[uuid.UUID] = None


class CategorySchool(BaseItem):
    branch_id: Optional[uuid.UUID] = None
    parent_category_school_id: Optional[uuid.UUID] = None


class Notion(BaseItem):
    pass


class RecommendationResponse(BaseModel):
    item: BaseItem
    recommendations: List[BaseItem]


# --- Хранилище данных и модель BERT ---
DATA: Dict[str, List[Dict[str, BaseItem]]] = {
    "philosophers": [],
    "works": [],
    "category_schools": [],
    "notions": [],
}

MODEL_NAME = "paraphrase-multilingual-MiniLM-L12-v2"
BERT_MODEL: Optional[SentenceTransformer] = None

# Матрицы эмбеддингов для каждого типа сущности
EMBEDDING_MATRICES: Dict[str, Optional[np.ndarray]] = {}


def load_data():
    pass


def prepare_embeddings():
    pass


@asynccontextmanager
async def startup_event(app: FastAPI):
    print("Загрузка данных...")
    load_data()
    print("Данные загружены. Подготовка BERT эмбеддингов...")
    prepare_embeddings()
    print("BERT эмбеддинги готовы. Сервис запущен.")
    yield


app = FastAPI(
    title="Философский Рекомендательный Сервис (BERT)",
    description="Контент-ориентированный рекомендательный сервис на FastAPI с использованием BERT эмбеддингов",
    version="0.2.0",
    lifespan=startup_event,
)


@app.get(
    "/recommendations/{item_type_slug}/{item_id_str}",
    response_model=RecommendationResponse,
)
async def get_recommendations(item_type_slug: str, item_id_str: str, top_n: int = 5):
    """
    Получить контент-ориентированные рекомендации для указанного элемента, используя BERT эмбеддинги.

    - **item_type_slug**: Тип сущности (например, `philosophers`, `works`, `notions`, `category_schools`).
    - **item_id_str**: UUID элемента в виде строки.
    - **top_n**: Количество рекомендуемых элементов.
    """
    if item_type_slug not in DATA:
        raise HTTPException(
            status_code=404, detail=f"Тип сущности '{item_type_slug}' не найден."
        )
    if not DATA[item_type_slug]:  # Проверка, что список не пуст
        raise HTTPException(
            status_code=404, detail=f"Нет данных для типа сущности '{item_type_slug}'."
        )

    embedding_matrix = EMBEDDING_MATRICES.get(item_type_slug)
    if embedding_matrix is None:  # Проверка, что эмбеддинги были созданы
        raise HTTPException(
            status_code=500,
            detail=f"Эмбеддинги для '{item_type_slug}' не инициализированы или не удалось создать.",
        )

    try:
        item_id = uuid.UUID(item_id_str)
    except ValueError:
        raise HTTPException(
            status_code=400, detail="Некорректный формат UUID для item_id."
        )

    items_list = DATA[item_type_slug]
    target_item_dict = None
    target_item_index = -1

    for i, item_dict in enumerate(items_list):
        if item_dict["id"] == item_id:
            target_item_dict = item_dict
            target_item_index = i
            break

    if target_item_dict is None:
        raise HTTPException(
            status_code=404,
            detail=f"Элемент с ID '{item_id_str}' не найден в '{item_type_slug}'.",
        )

    target_vector = embedding_matrix[target_item_index].reshape(
        1, -1
    )  # reshape для cosine_similarity

    # Рассчитываем косинусное сходство
    cosine_similarities = cosine_similarity(target_vector, embedding_matrix).flatten()

    similar_items_indices = cosine_similarities.argsort()[-(top_n + 2) : -1][
        ::-1
    ]  # +2 чтобы точно исключить сам элемент и взять top_n

    recommendations_dicts = []
    for i in similar_items_indices:
        if i == target_item_index:  # Пропускаем сам элемент
            continue
        if len(recommendations_dicts) < top_n:
            recommendations_dicts.append(items_list[i])
        else:
            break

    model_map = {
        "philosophers": Philosopher,
        "works": Work,
        "category_schools": CategorySchool,
        "notions": Notion,
    }
    ItemModel = model_map.get(item_type_slug, BaseItem)

    try:
        target_item_pydantic = ItemModel(**target_item_dict)
        recommendations_pydantic = [
            ItemModel(**rec_dict) for rec_dict in recommendations_dicts
        ]
    except Exception as e:
        print(f"Ошибка при преобразовании в Pydantic модель: {e}")
        raise HTTPException(
            status_code=500, detail=f"Ошибка при формировании ответа: {e}"
        )

    return RecommendationResponse(
        item=target_item_pydantic, recommendations=recommendations_pydantic
    )


@app.get("/")
async def root():
    return {"message": "Добро пожаловать в Философский Рекомендательный Сервис (BERT)!"}
