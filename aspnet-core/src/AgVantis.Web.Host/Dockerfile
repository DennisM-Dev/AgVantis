FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/AgVantis.Web.Host/AgVantis.Web.Host.csproj", "src/AgVantis.Web.Host/"]
COPY ["src/AgVantis.Web.Core/AgVantis.Web.Core.csproj", "src/AgVantis.Web.Core/"]
COPY ["src/AgVantis.Application/AgVantis.Application.csproj", "src/AgVantis.Application/"]
COPY ["src/AgVantis.Core/AgVantis.Core.csproj", "src/AgVantis.Core/"]
COPY ["src/AgVantis.EntityFrameworkCore/AgVantis.EntityFrameworkCore.csproj", "src/AgVantis.EntityFrameworkCore/"]
WORKDIR "/src/src/AgVantis.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/AgVantis.Web.Host", "src/AgVantis.Web.Host"]
COPY ["src/AgVantis.Web.Core", "src/AgVantis.Web.Core"]
COPY ["src/AgVantis.Application", "src/AgVantis.Application"]
COPY ["src/AgVantis.Core", "src/AgVantis.Core"]
COPY ["src/AgVantis.EntityFrameworkCore", "src/AgVantis.EntityFrameworkCore"]
WORKDIR "/src/src/AgVantis.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "AgVantis.Web.Host.dll"]
