# C HelloWorld

A simple Hello World application written in C.

## Execution Instructions

```bash
gcc main.c -o hello
./hello
```

## Dockerization

Incorporate your Dockerfile here to containerize this application. After adding your Dockerfile, refer to the following steps:
`docker build -t c-multi-hello .`
`docker run c-multi-hello:latest`

### To Compare Single-Stage Dockerfile with Multi-Stage Dockerfile
Update the following in your `Dockerfile`:
```
FROM gcc
WORKDIR /app
COPY . .
RUN gcc main.c -o hello
CMD ["./hello"]
```
Rebuild using the previous commands:
`docker build -t c-hello .`
`docker run c-hello:latest`

After the new image has been built, check the image sizes with:
`docker image ls`
<img width="952" height="118" alt="image" src="https://github.com/user-attachments/assets/294128e1-36d4-4573-a3ad-6937905dfd3a" />
