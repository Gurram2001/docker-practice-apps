FROM gcc:latest as build-env
WORKDIR /app
COPY . .
RUN gcc calculator.c -o calculator -static
FROM alpine:latest
WORKDIR /app
COPY --from=build-env /app/calculator .
CMD ["./calculator"]
