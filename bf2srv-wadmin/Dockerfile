#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# For use in Visual Studio
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src

COPY ["src/bf2srv-wadmin.Server/bf2srv-wadmin.Server.csproj", "src/bf2srv-wadmin.Server/"]
COPY ["src/bf2srv-wadmin.Data/bf2srv-wadmin.Data.csproj", "src/bf2srv-wadmin.Data/"]
COPY ["src/bf2srv-wadmin.Common/bf2srv-wadmin.Common.csproj", "src/bf2srv-wadmin.Common/"]
COPY ["src/bf2srv-wadmin.Shared/bf2srv-wadmin.Shared.csproj", "src/bf2srv-wadmin.Shared/"]
COPY ["src/bf2srv-wadmin.Blazor/bf2srv-wadmin.Blazor.csproj", "src/bf2srv-wadmin.Blazor/"]

COPY ./nuget.config /src/nuget.config

RUN dotnet restore "src/bf2srv-wadmin.Server/bf2srv-wadmin.Server.csproj" --configfile ./nuget.config

COPY . .
WORKDIR "/src/src/bf2srv-wadmin.Server"
RUN dotnet build "bf2srv-wadmin.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bf2srv-wadmin.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bf2srv-wadmin.Server.dll"]