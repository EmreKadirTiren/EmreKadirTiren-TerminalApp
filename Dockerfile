FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Kopieer alle projectbestanden
COPY . .

# Restore afhankelijkheden en build het project
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore

# Runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app .

# Stel het startpunt in op de applicatie DLL
ENTRYPOINT ["dotnet", "EmreKadirTiren-ConsoleApp.dll"]