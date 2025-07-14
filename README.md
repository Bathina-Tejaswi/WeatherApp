# WeatherApp

A Blazor WebAssembly + ASP.NET Core hosted application to fetch and display weather information by city.

## Features

- Search weather by city name
- Call real-time weather data from OpenWeatherMap API
- Save searched locations
- SQL Server backend for persistence
- Clean architecture with shared models

## Technologies

- Blazor WebAssembly (.NET 7)
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- OpenWeatherMap API

## Getting Started

1. Clone the repo:

2. Open `WeatherApp1.sln` in Visual Studio 2022+

3. Update `appsettings.json` in `WeatherApp1.Server` with your SQL connection string

4. Update `WeatherPage.razor` in `WeatherApp1.Client` with your API Key

5. Run the project (Server should be the startup project)
