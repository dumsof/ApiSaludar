#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ApiSaludar/ApiSaludar.csproj", "ApiSaludar/"]
COPY ["Saludar.DataAccess/Saludar.DataAccess.csproj", "Saludar.DataAccess/"]
COPY ["Saludar.EntitiesDto/Saludar.EntitiesDto.csproj", "Saludar.EntitiesDto/"]
COPY ["LoggerService/LoggerService.csproj", "LoggerService/"]
COPY ["Saludar.Business/Saludar.Business.csproj", "Saludar.Business/"]
COPY ["Saludar.Mensaje/Saludar.Mensajes.csproj", "Saludar.Mensaje/"]
RUN dotnet restore "ApiSaludar/ApiSaludar.csproj"
COPY . .
WORKDIR "/src/ApiSaludar"
RUN dotnet build "ApiSaludar.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApiSaludar.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiSaludar.dll"]

# syntax=docker/dockerfile:1
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
#WORKDIR /app
#
## Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore
#
## Copy everything else and build
#COPY ../engine/examples ./
#RUN dotnet publish -c Release -o out
#
## Build runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:3.1
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "ApiSaludar.dll"]