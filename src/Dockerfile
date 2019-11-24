FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Production

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src

# copy csproj and restore as distinct layers
COPY ["OpenAPI.NBRB.Api/OpenAPI.NBRB.Api.csproj", "OpenAPI.NBRB.Api/"]
COPY ["OpenAPI.NBRB.Common/OpenAPI.NBRB.Common.csproj", "OpenAPI.NBRB.Common/"]
COPY ["OpenAPI.NBRB.Data/OpenAPI.NBRB.Data.csproj", "OpenAPI.NBRB.Data/"]
COPY ["OpenAPI.NBRB.Data.Contracts/OpenAPI.NBRB.Data.Contracts.csproj", "OpenAPI.NBRB.Data.Contracts/"]
COPY ["OpenAPI.NBRB.Data.InMemory/OpenAPI.NBRB.Data.InMemory.csproj", "OpenAPI.NBRB.Data.InMemory/"]
COPY ["OpenAPI.NBRB.Domain.Contracts/OpenAPI.NBRB.Domain.Contracts.csproj", "OpenAPI.NBRB.Domain.Contracts/"]
COPY ["OpenAPI.NBRB.Domain.Services/OpenAPI.NBRB.Domain.Services.csproj", "OpenAPI.NBRB.Domain.Services/"]
COPY ["OpenAPI.NBRB.Infrastructure/OpenAPI.NBRB.Infrastructure.csproj", "OpenAPI.NBRB.Infrastructure/"]

RUN dotnet restore "OpenAPI.NBRB.Api/OpenAPI.NBRB.Api.csproj"
COPY . .
WORKDIR "/src/OpenAPI.NBRB.Api"
RUN dotnet build "OpenAPI.NBRB.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OpenAPI.NBRB.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OpenAPI.NBRB.Api.dll"]
