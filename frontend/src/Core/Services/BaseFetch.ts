import type { ApiResponse } from "../types/ApiResponse";

const API_BASE = import.meta.env.APP_API_URL;

type RequestInitWithRetry = RequestInit & { _retry?: boolean };

export async function BaseFetch<T = unknown>(
  input: RequestInfo,
  init: RequestInitWithRetry = {}
): Promise<ApiResponse<T>> {
  try {
    const response = await fetch(`${API_BASE}${input}`, {
      ...init,
      signal: init.signal,
      credentials: "include",
    });

    // Handle 204 No Content response
    if (response.status === 204) {
      return {
        statusCode: 204,
        isSuccess: true,
        result: null as unknown as T,
        errors: [],
      } as ApiResponse;
    }

    const data = (await response.json()) as ApiResponse<T>;
    if (data.statusCode >= 400 && data.statusCode < 600) {
      throw data;
    }
    return data;
  } catch (error) {
    if (error instanceof Error && error.name === "AbortError") {
      console.log("❌ Request was cancelled");
    } else {
      console.error("🔥 Request failed:", error);
    }
    throw error;
  }
}
