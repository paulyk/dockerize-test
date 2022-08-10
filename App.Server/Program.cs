using App.Model;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true)
    .AddJsonFile("appsettings.Development.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddSingleton<Greeter>();

var app = builder.Build();

var getTodo = (string id) => config[$"todo:{id}"] != null ? config[$"todo:{id}"] : "not found";

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet", (Greeter greeter) => greeter.Greet);
app.MapGet("/app-title", () => config["AppTitle"] ?? "No title");
app.MapGet("/connection-string", () => config.GetConnectionString("Default"));
 app.MapGet("/todo/{id}", (string id) => getTodo(id));

app.Run();
