FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["TrustCoreEnterprise/TrustCoreEnterprise.csproj", "TrustCoreEnterprise/"]
RUN dotnet restore "TrustCoreEnterprise/TrustCoreEnterprise.csproj"
COPY . .
WORKDIR "/src/TrustCoreEnterprise"
RUN dotnet build "TrustCoreEnterprise.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TrustCoreEnterprise.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TrustCoreEnterprise.dll"]