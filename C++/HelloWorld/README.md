# C++ HelloWorld

Simple Hello World app in C++.

## How to Run

```bash
g++ main.cpp -o hello
./hello
```

## Dockerization

Incorporate your Dockerfile here to containerize this application. After adding your Dockerfile, refer to the following steps: 
1. `docker build -t manikarthik2001/cpphello-mul .`
2. `docker run manikarthik2001/cpphello-mul:latest`

To Compare Single-Stage Dockerfile with Multi-Stage Dockerfile
Update the following in your Dockerfile:
```
FROM gcc:latest
WORKDIR /app
COPY . .
RUN g++ main.cpp -o hello
CMD ["./hello"]
```
Rebuild using the previous commands: 
1. `docker build -t manikarthik2001/cpphello .`
2. `docker run manikarthik2001/cpphello:latest`

After the new image has been built, check the image sizes with: docker image ls
<img width="1094" height="97" alt="image" src="https://github.com/user-attachments/assets/1abca594-b6ba-43e7-ae84-fd093de072e8" />
