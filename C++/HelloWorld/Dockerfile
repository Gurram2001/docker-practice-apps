FROM gcc:latest as build
WORKDIR /app
COPY . .
RUN g++ main.cpp -o hello -static
FROM alpine:latest
WORKDIR /app
COPY --from=build /app/hello .
CMD ["./hello"] 
