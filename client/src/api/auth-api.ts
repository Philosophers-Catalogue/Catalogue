import {
  RegisterRequest,
  HttpValidationProblemDetails,
  LoginRequest,
  AccessTokenResponse,
  ApiError,
} from "../types";

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
    throw { ...errorData, status: response.status };
  } else {
    const errorText = await response.text();
    throw {
      message: `Registration failed: ${response.status} ${
        errorText || response.statusText
      }`,
      status: response.status,
    };
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
  data: LoginRequest,
  params?: { useCookies?: boolean; useSessionCookies?: boolean }
): Promise<AccessTokenResponse> => {
  // Формируем URL с query параметрами, если они предоставлены
  const url = new URL(`${BASE_URL}login`);
  if (params?.useCookies !== undefined) {
    url.searchParams.append("useCookies", String(params.useCookies));
  }
  if (params?.useSessionCookies !== undefined) {
    url.searchParams.append(
      "useSessionCookies",
      String(params.useSessionCookies)
    );
  }

  const response = await fetch(url.toString(), {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(data),
  });

  if (response.ok) {
    const responseData: AccessTokenResponse = await response.json();
    return responseData;
  } else {
    try {
      const errorData: ApiError = await response.json();
      throw { ...errorData, status: response.status };
    } catch (e: any) {
      const errorText = await response.text().catch(() => response.statusText); // Попытка получить текст, если не получилось, то statusText
      throw {
        message: `Login failed: ${response.status} ${errorText}`,
        status: response.status,
      };
    }
  }
};
