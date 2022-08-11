using App.Model;
using App.Server;

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", true)
    .AddJsonFile("appsettings.Development.json", optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddScoped<DataDb>();
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();



app.MapGraphQL();
app.MapGet("/", () => "Hello World!");
app.MapGet("/app-title", () => config["AppTitle"] ?? "No title");


app.Run();
