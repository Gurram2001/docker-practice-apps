using Microsoft.AspNetCore.Builder;
var app = WebApplication.Create();
app.MapGet("/", () => "Hello Web API!");
app.Run();
