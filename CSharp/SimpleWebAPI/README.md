# CSharp SimpleWebAPI

Minimal Web API example in C# using .NET 6+.

## How to Run

```bash
dotnet run
```

## Dockerization

Incorporate your Dockerfile here to containerize this application. After adding your Dockerfile, refer to the following steps: 
1. `docker build -t manikarthik2001/csharp-simplewebapi-multi .`
2. `docker run manikarthik2001/csharp-simplewebapi-multi:latest`

To Compare Single-Stage Dockerfile with Multi-Stage Dockerfile
Update the following in your Dockerfile:
```
FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /app
COPY . .
RUN dotnet new console --force && dotnet build -c Release
CMD ["dotnet", "run"]
```
Rebuild using the previous commands: 
1. `docker build -t manikarthik2001/csharp-simplewebapi .`
2. `docker run  manikarthik2001/csharp-simplewebapi:latest`

After the new image has been built, check the image sizes with: `docker image ls` or `docker images`
<img width="1225" height="85" alt="image" src="https://github.com/user-attachments/assets/30b88b4d-937f-48b6-839d-675181d46164" />
