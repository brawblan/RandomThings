# RandomThings

![.NET](https://github.com/brawblan/RandomThings/actions/workflows/dotnet.yml/badge.svg)
[![Render](https://img.shields.io/badge/Render-46E3B7?style=for-the-badge&logo=render&logoColor=white)](https://render.com/)
![Live](https://img.shields.io/badge/status-live-success)

A C#/.NET web API that provides random data through RESTful endpoints. This project showcases practical ASP.NET Core development skills, including RESTful endpoint design, service layer architecture, Entity Framework Core integration, and automated deployment pipelines. Live on Azure with a custom domain, demonstrating end-to-end cloud deployment capabilities.

## 🌐 Live API

The API is publicly accessible at: **https://randomthings.brandonblankenste.in**

Try it out directly in your browser or with any HTTP client!

## API Endpoints

### Colors

Get random colors or browse the color collection.

- **GET** `/colors` - Returns all available colors
  - Example: https://randomthings.brandonblankenste.in/colors
  - Response: `[{"id": 1, "name": "Red"}, {"id": 2, "name": "Blue"}, ...]`

- **GET** `/colors/random` - Returns a random color
  - Example: https://randomthings.brandonblankenste.in/colors/random
  - Response: `{"id": 3, "name": "Yellow"}`

- **GET** `/colors/{id}` - Returns a specific color by ID
  - Example: https://randomthings.brandonblankenste.in/colors/1
  - Response: `{"id": 1, "name": "Red"}`

### Numbers

Generate random numbers on demand.

- **GET** `/numbers` - Returns a random number between 0 and 100
  - Example: https://randomthings.brandonblankenste.in/numbers
  - Response: `42`

## Local Development

When running locally, additional endpoints are available:

- **POST** `/colors` - Create new colors (accepts JSON body with `name` property)
- **Swagger UI** - Interactive API documentation at `https://localhost:7103/swagger`

To run locally:

```bash
dotnet run
```

## Built With

### Backend

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![REST API](https://img.shields.io/badge/REST%20API-009688?style=for-the-badge&logo=fastapi&logoColor=white)
![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)

### Cloud & Infrastructure

![Azure](https://img.shields.io/badge/Azure-0078D4?style=for-the-badge&logo=microsoft-azure&logoColor=white)

### Development Workflow

![GitHub Actions](https://img.shields.io/badge/GitHub%20Actions-2088FF?style=for-the-badge&logo=github-actions&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)
