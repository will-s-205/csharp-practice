// USE VCODE AND C# EXTENSION
// CTRL+F5 to run without debugging

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
