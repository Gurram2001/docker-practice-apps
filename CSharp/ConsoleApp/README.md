# CSharp ConsoleApp

Simple Hello World console application in C#.

## How to Run

```bash
dotnet new console
dotnet run
```

## Dockerization

Incorporate your Dockerfile here to containerize this application. After adding your Dockerfile, refer to the following steps: 
1. `docker build -t manikarthik2001/csharp-multistage-program .`
2. `docker run manikarthik2001/csharp-multistage-program:latest`

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
1. `docker build -t manikarthik2001/csharp-program .`
2. `docker run manikarthik2001/csharp-program:latest`

After the new image has been built, check the image sizes with: docker image ls
<img width="1143" height="140" alt="image" src="https://github.com/user-attachments/assets/8fc09269-d8f0-439e-8839-b3b2d6f47b6b" />
