FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build

WORKDIR /app

# Copy Projects
COPY src/CardGenerator.Web/CardGenerator.Web.csproj src/CardGenerator.Web/
COPY src/CardGenerator.Domain/CardGenerator.Domain.csproj src/CardGenerator.Domain/
COPY src/CardGenerator.Application/CardGenerator.Application.csproj src/CardGenerator.Application/

# Restore
RUN dotnet restore src/CardGenerator.Web/CardGenerator.Web.csproj

COPY src ./src

# Build and publish
RUN dotnet publish src/CardGenerator.Web/CardGenerator.Web.csproj -c Release -o /publish

#ASP.NET Core Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS runtime
WORKDIR /app
COPY --from=build /publish .

EXPOSE 5000
ENTRYPOINT ["dotnet", "CardGenerator.Web.dll"]