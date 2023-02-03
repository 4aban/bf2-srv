#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# For use in Visual Studio
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/bf2srvWebAdmin.Server/bf2srvWebAdmin.Server.csproj", "src/bf2srvWebAdmin.Server/"]
COPY ["src/bf2srvWebAdmin.Data/bf2srvWebAdmin.Data.csproj", "src/bf2srvWebAdmin.Data/"]
COPY ["src/bf2srvWebAdmin.Common/bf2srvWebAdmin.Common.csproj", "src/bf2srvWebAdmin.Common/"]
COPY ["src/bf2srvWebAdmin.Shared/bf2srvWebAdmin.Shared.csproj", "src/bf2srvWebAdmin.Shared/"]
COPY ["src/bf2srvWebAdmin.Blazor/bf2srvWebAdmin.Blazor.csproj", "src/bf2srvWebAdmin.Blazor/"]
COPY ./nuget.config /src/nuget.config
RUN dotnet restore "src/bf2srvWebAdmin.Server/bf2srvWebAdmin.Server.csproj" --configfile ./nuget.config
#RUN dotnet restore "src/bf2srvWebAdmin.Server/bf2srvWebAdmin.Server.csproj"
COPY . .
WORKDIR "/src/src/bf2srvWebAdmin.Server"
RUN dotnet build "bf2srvWebAdmin.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "bf2srvWebAdmin.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "bf2srvWebAdmin.Server.dll"]