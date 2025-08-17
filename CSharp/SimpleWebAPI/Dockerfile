FROM mcr.microsoft.com/dotnet/sdk as build
WORKDIR /app1
COPY . .
RUN dotnet new console --force && dotnet publish -c Release -o out
FROM mcr.microsoft.com/dotnet/runtime
WORKDIR /app
COPY --from=build /app1/out .
CMD ["dotnet", "app1.dll"]
