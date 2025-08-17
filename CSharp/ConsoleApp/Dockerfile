FROM mcr.microsoft.com/dotnet/sdk:latest as buildenv
WORKDIR /app
COPY . .
RUN dotnet new console --force && dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/runtime:latest
WORKDIR /app
COPY --from=buildenv /app/out .
CMD ["dotnet", "app.dll"]
