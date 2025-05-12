// Базовый URL вашего API (из поля "servers")

export interface RegisterRequest {
  email: string;
  password: string;
}

export interface LoginRequest {
  email: string;
  password: string;
  twoFactorCode?: string | null;
  twoFactorRecoveryCode?: string | null;
}

export interface AccessTokenResponse {
  tokenType: string | null;
  accessToken: string;
  expiresIn: number;
  refreshToken: string;
}

export interface HttpValidationProblemDetails {
  type?: string | null;
  title?: string | null;
  status?: number | null;
  detail?: string | null;
  instance?: string | null;
  errors?: {
    [key: string]: string[];
  };
}

// Возможные типы ошибок для методов API
export type ApiError =
  | HttpValidationProblemDetails
  | { message: string; status?: number };
