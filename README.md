# HGamesAPI

<a href="https://ibb.co/LrpyTbV"><img src="https://i.ibb.co/PMCy23q/123.png" alt="123" border="0"></a><br /><br />

![Static Badge](https://img.shields.io/badge/Framework-ASP.NET_8.0-purple?logo=dotnet) ![Static Badge](https://img.shields.io/badge/Language-C%23-purple?logo=csharp) ![Static Badge](https://img.shields.io/badge/DataBase-MSSQL-purple?logo=microsoftsqlserver)

## About

`HGamesAPI` предоставляет функционал работы с базой данных игр через RESTful API. Основные доступные команды:

### Методы API

- `GET /api/HGames` - Получение списка всех игр.
- `POST /api/HGames` - Добавление новой игры в базу данных.
- `GET /api/HGames/{id}` - Получение информации о конкретной игре по ID.
- `GET /api/HGames/search` - Поиск игр по заданным параметрам.

### Схема данных

#### HGames_Information

| Поле         | Тип              | Описание                             |
|--------------|------------------|--------------------------------------|
| `id`         | `integer($int32)`| Уникальный идентификатор игры        |
| `name`       | `string`         | Название игры (nullable)             |
| `photo`      | `string`         | URL изображения игры (nullable)      |
| `description`| `string`         | Описание игры (nullable)             |
| `url`        | `string`         | URL игры (nullable)                  |

## Installation

1. Клонируйте репозиторий:

    ```bash
    git clone https://github.com/He11Cut3/HGamesAPI.git
    ```

2. Перейдите в директорию проекта:

    ```bash
    cd HGamesAPI
    ```

3. Установите зависимости:

    - Убедитесь, что у вас установлена SDK для .NET и необходимые библиотеки.
    - Используйте менеджер пакетов NuGet для установки необходимых пакетов, если они не установлены:

    ```bash
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    dotnet add package Swashbuckle.AspNetCore
    ```

4. Настройте файл `appsettings.json` или переменные среды для хранения строки подключения к базе данных и других необходимых настроек.

## Developers

- [He11Cut3](https://github.com/He11Cut3)
