# C Calculator

Simple calculator app to add two numbers.

## How to Run

```bash
gcc calculator.c -o calculator
./calculator
```

## Dockerization

Incorporate your Dockerfile here to containerize this application. After adding your Dockerfile, refer to the following steps:
1. `docker build -t c-mul-calc .`
2. `docker run -it manikarthik2001/c-mul-calc:lates`

To Compare Single-Stage Dockerfile with Multi-Stage Dockerfile
Update the following in your Dockerfile:
```
FROM gcc
WORKDIR /app
COPY . .
RUN gcc calculator.c -o calculator
CMD ["./calculator"]
```
Rebuild using the previous commands: 
* `docker build -t  manikarthik2001/c-calc .`
* `docker run -it manikarthik2001/c-calc:lates`
After the new image has been built, check the image sizes with: docker image ls
Here is diff.
<img width="1064" height="97" alt="image" src="https://github.com/user-attachments/assets/bfb6a79d-6726-45c9-9b4d-855e95c8ae40" />

