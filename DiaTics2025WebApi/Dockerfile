# BUILD
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY DiaTics2025.sln .

# Copiar cada proyecto individualmente
COPY DiaTics2025WebApi/DiaTics2025WebApi.csproj DiaTics2025WebApi/
COPY DiaTics2025/DiaTics2025.csproj DiaTics2025/
COPY Shared/Domain.csproj Shared/
COPY Data/Data.csproj Data/
COPY Business/Business.csproj Business/
COPY DiaTics2025Pxy/Service.csproj DiaTics2025Pxy/

RUN dotnet restore DiaTics2025.sln

#SE COPIA TODO EL CODIGO
COPY . .

WORKDIR /src/DiaTics2025WebApi
RUN dotnet publish -c Release -o /app/publish

# RUNTIME
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DiaTics2025WebApi.dll"]
