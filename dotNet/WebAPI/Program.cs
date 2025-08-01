using Microsoft.AspNetCore.Builder;
var app = WebApplication.Create();
app.MapGet("/", () => "Hello from .NET WebAPI!");
app.Run();
