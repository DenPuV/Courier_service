#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Courier_service/Courier_service.csproj", "Courier_service/"]
RUN dotnet restore "Courier_service/Courier_service.csproj"
COPY . .
WORKDIR "/src/Courier_service"
RUN dotnet build "Courier_service.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Courier_service.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Courier_service.dll"]