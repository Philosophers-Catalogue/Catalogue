FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Philosophers-Catalogue/Philosophers-Catalogue.csproj", "Philosophers-Catalogue/"]
RUN dotnet restore "Philosophers-Catalogue/Philosophers-Catalogue.csproj"
COPY . .
WORKDIR "/src/Philosophers-Catalogue"
RUN dotnet build "Philosophers-Catalogue.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Philosophers-Catalogue.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Philosophers-Catalogue.dll"]
