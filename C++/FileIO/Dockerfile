FROM gcc:latest as dev
WORKDIR /app
COPY . .
RUN g++ fileio.cpp -o fileio -static
FROM alpine:latest
WORKDIR /app
COPY --from=dev /app/fileio .
CMD ["./fileio"]                                                                                                                                                               
