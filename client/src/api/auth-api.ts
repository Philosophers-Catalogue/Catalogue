import {
  RegisterRequest,
  HttpValidationProblemDetails,
  LoginRequest,
  AccessTokenResponse,
  ApiError as ApiErrorType,
} from "../types";

class ApiError extends Error {
  status: number;

  constructor(message: string, status: number) {
    super(message);
    this.status = status;
  }
}

const BASE_URL = import.meta.env.VITE_BASE_API_URL;
/**
 * Регистрирует нового пользователя.
 * @param data Данные для регистрации (email и пароль).
 * @returns Promise, который разрешается при успешной регистрации (статус 200 OK)
 * или отклоняется с объектом ApiError при ошибке.
 */
export const register = async (data: RegisterRequest): Promise<void> => {
  const response = await fetch(`${BASE_URL}register`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  });

  if (response.ok) {
    return;
  } else if (response.status === 400) {
    const errorData: HttpValidationProblemDetails = await response.json();
    throw new Error(errorData.detail ?? "Произошла ошибка при регистрации.");
  } else {
    const errorText = await response.text();
    throw new ApiError(
      `Registration failed: ${response.status} ${
        errorText || response.statusText
      }`,
      response.status
    );
  }
};

/**
 * Выполняет вход пользователя в систему.
 * @param data Данные для входа (email, пароль, опционально 2FA коды).
 * @param params Параметры запроса (useCookies, useSessionCookies).
 * @returns Promise, который разрешается с AccessTokenResponse при успешном входе
 * или отклоняется с объектом ApiError при ошибке.
 */
export const login = async (
  data: LoginRequest
): Promise<AccessTokenResponse> => {
  // Формируем URL с query параметрами, если они предоставлены
  const url = new URL(
    `${BASE_URL}login?useCookies=true&useSessionCookies=true`
  );

  const response = await fetch(url.toString(), {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
    credentials: "include",
  });

  if (response.ok) {
    const responseData: AccessTokenResponse = await response.json();
    return responseData;
  } else {
    const errorData: ApiErrorType = await response.json();
    throw errorData;
  }
};

export const logout = async (): Promise<void> => {
  const response = await fetch(`${BASE_URL}logout`, {
    method: "POST",
    body: JSON.stringify({}),
    credentials: "include",
  });

  if (!response.ok) {
    const errorText = await response.text();
    throw new ApiError(
      `Logout failed: ${response.status} ${errorText || response.statusText}`,
      response.status
    );
  }
};

export const checkAuth = async (): Promise<{
  email: string;
  isEmailConfirmed: boolean;
} | null> => {
  const response = await fetch(`${BASE_URL}info`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
    },
    credentials: "include",
  });

  if (response.ok) {
    return await response.json();
  }

  if (response.status === 401) {
    return null;
  }

  const errorText = await response.text();
  throw new ApiError(
    `Auth check failed: ${response.status} ${errorText || response.statusText}`,
    response.status
  );
};

export type {
  RegisterRequest,
  LoginRequest,
  AccessTokenResponse,
  ApiErrorType as ApiError,
};
