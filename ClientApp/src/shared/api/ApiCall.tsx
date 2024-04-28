import { useState, useEffect } from "react";

import { ApiRequestProps } from "./model/ApiRequest.props";
import { ApiResultProps } from "./model/ApiResult.props";

const ApiRequest = <T,>({
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

    useEffect(() => {
        const fetchData = async () => {
            setLoading(true);
            setSuccess(false);
            setError(null);
            try {
                const response = await fetch(fullUrl, {
                    method: method || "GET",
                    headers: {
                        "Content-Type": "application/json",
                    },
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

        fetchData();
    }, [url, method, body, fullUrl]);

    return { data, loading, error, success };
};

export default ApiRequest;

// 
// ПРИМЕР ИСПОЛЬЗОВАНИЯ КОМПОНЕНТА
// 

// Интерфейс для ответа сервера при получении списка пользователей
// interface User {
//   id: number;
//   name: string;
//   email: string;
// }

// Интерфейс для тела запроса при создании пользователя
// interface CreateUserRequest {
//   name: string;
//   email: string;
//   password: string;
// }

// Интерфейс для ответа сервера при создании пользователя
// interface CreateUserResponse {
//   id: number;
//   name: string;
//   email: string;
// }

// const App = () => {
//   Получение списка пользователей
//   const { data: users, loading: usersLoading, error: usersError } = ApiRequest<User[]>({
//     url: 'users', // Относительный путь
//     method: 'GET',
//   });

//   Создание нового пользователя:
// 
//   const { data: newUser, loading: newUserLoading, error: newUserError, success: newUserSuccess } = ApiRequest<CreateUserResponse>({
//     url: 'users', 
//     method: 'POST',
//     body: {
//       name: 'John Doe',
//       email: 'john.doe@example.com',
//       password: 'mypassword',
//     } as CreateUserRequest,
//   });

//   return (
//     <div>
//       <h1>User List</h1>
//       {usersLoading && <div>Loading users...</div>}
//       {usersError && <div>Error: {usersError.message}</div>}
//       <ul>
//         {users?.map((user) => (
//           <li key={user.id}>
//             {user.name} ({user.email})
//           </li>
//         ))}
//       </ul>

//       <h2>Create User</h2>
//       {newUserLoading && <div>Creating user...</div>}
//       {newUserError && <div>Error: {newUserError.message}</div>}
//       {newUserSuccess && <div>User created successfully!</div>}
//     </div>
//   );
// };

// export default App;