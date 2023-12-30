#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/ZNet.Host/ZNet.Host.csproj", "src/ZNet.Host/"]
RUN dotnet restore "src/ZNet.Host/ZNet.Host.csproj"
COPY . .
WORKDIR "/src/src/ZNet.Host"
RUN dotnet build "ZNet.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZNet.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZNet.Host.dll"]