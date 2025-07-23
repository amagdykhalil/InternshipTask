
# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG CONNECTION_STRING
ARG ALLOWED_ORIGINS__0

ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["InternshipTask.API/InternshipTask.API.csproj", "InternshipTask.API/"]
COPY ["InternshipTask.BusinessLayer/InternshipTask.BusinessLayer.csproj", "InternshipTask.BusinessLayer/"]
COPY ["InternshipTask.DataLayer/InternshipTask.DataLayer.csproj", "InternshipTask.DataLayer/"]
RUN dotnet restore "InternshipTask.API/InternshipTask.API.csproj"

COPY . .
# Pass build args to ENV for runtime
ENV ConnectionStrings__DefaultConnection=$CONNECTION_STRING
ENV AllowedOrigins__0=$ALLOWED_ORIGINS__0
ENV ASPNETCORE_ENVIRONMENT="Production"

## Run migrations
FROM build as migrations
RUN dotnet tool install --version 9.0.7 --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"
ENTRYPOINT dotnet-ef database update --project InternshipTask.DataLayer/ --startup-project InternshipTask.API/


WORKDIR "/src/InternshipTask.API"
RUN dotnet build "./InternshipTask.API.csproj" -c Release  -o /app/build


# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "InternshipTask.API/InternshipTask.API.csproj" -c Release  -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InternshipTask.API.dll"]
