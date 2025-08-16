# C++ FileIO

Simple file writing example in C++.

## How to Run

```bash
g++ fileio.cpp -o fileio
./fileio
```

## Dockerization

Integrate your Dockerfile here for containerizing the application. Once you have added your Dockerfile, follow these steps:
Start by creating a Docker volume to store the data in sample.txt:
1. `docker volume create file-cpp`
2. `docker build -t manikarthik2001/cpp-fileio-mul .`
3. `docker run --mount type=volume,src=file-cpp,dst=/app manikarthik2001/cpp-fileio-mul:latest`
4. `docker inspect file-cpp`
5. Verify the mount point and inspect the folder

To compare a Single-Stage Dockerfile with a Multi-Stage Dockerfile, modify your Dockerfile as follows:
```
FROM gcc
WORKDIR /app
COPY . .
RUN g++ fileio.cpp -o fileio
CMD ["./fileio"]
```
Rebuild the image using the previous commands and create a new volume:
1. `docker volume create file-cpp1`
2. `docker build -t manikarthik2001/cpp-fileio .`
3. `docker run --mount type=volume,src=file-cpp,dst=/app manikarthik2001/cpp-fileio:latest`
4. `docker inspect file-cpp1`
5. Verify the mount point and inspect the folder
After building the new image, check the image sizes with: `docker image ls`
<img width="1033" height="87" alt="image" src="https://github.com/user-attachments/assets/385b2cc8-5ac6-4c3e-b8dd-b109cbf10849" />
