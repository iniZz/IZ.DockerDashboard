FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["IZ.DockerDashboard.Web/IZ.DockerDashboard.Web.csproj", "IZ.DockerDashboard.Web/"]
RUN dotnet restore "IZ.DockerDashboard.Web/IZ.DockerDashboard.Web.csproj"
COPY . .
WORKDIR "/src/IZ.DockerDashboard.Web"
RUN dotnet build "IZ.DockerDashboard.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "IZ.DockerDashboard.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IZ.DockerDashboard.Web.dll"]
