using App.Model;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true)
    .AddJsonFile("appsettings.Development.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

var x = config["Todo:1"];
Console.WriteLine(x);

builder.Services.AddSingleton<Greeter>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet", (Greeter greeter) => greeter.Greet);
app.MapGet("/app-title", () => config["AppTitle"] ?? "No title");
app.MapGet("/connection-string", () => config.GetConnectionString("Default"));
// app.MapGet("/todo:id")

app.Run("http://localhost:8000");
