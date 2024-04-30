import { useState, useEffect } from "react";

import { ApiRequestProps } from "./model/ApiRequest.props";
import { ApiResultProps } from "./model/ApiResult.props";

const ApiCall = <T,>({
    url,
    method,
    body,
}: ApiRequestProps): ApiResultProps<T> => {
    const baseUrl = "http://localhost:3000/api/"; // Базовый URL
    const fullUrl = `${baseUrl}${url}`; // Объединение базового URL и переданного URL

    const [data, setData] = useState<T | null>(null);
    const [loading, setLoading] = useState<boolean>(false);
    const [error, setError] = useState<Error | null>(null);
    const [success, setSuccess] = useState<boolean>(false);
        const fetchData = async () => {
            setLoading(true);
            setSuccess(false);
            setError(null);
            try {
                const token = localStorage.getItem("token");

                const headers: Record<string, string> = {
                    "Content-Type": "application/json",
                };

                if (token) {
                    headers["token"] = token;
                }

                const response = await fetch(fullUrl, {
                    method: method || "GET",
                    headers,
                    body: body ? JSON.stringify(body) : null,
                });
                if (response.ok) {
                    const data = await response.json();
                    setData(data);
                    setSuccess(true);
                } else {
                    setError(new Error(`HTTP error ${response.status}`));
                }
            } catch (error) {
                setError(error as Error);
            } finally {
                setLoading(false);
            }
        };

     fetchData()

    return { data, loading, error, success };
};

export default ApiCall;

