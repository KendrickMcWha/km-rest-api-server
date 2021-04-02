#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["km-rest-api-server/km-rest-api-server.csproj", "km-rest-api-server/"]
RUN dotnet restore "km-rest-api-server/km-rest-api-server.csproj"
COPY . .
WORKDIR "/src/km-rest-api-server"
RUN dotnet build "km-rest-api-server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "km-rest-api-server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "km-rest-api-server.dll"]