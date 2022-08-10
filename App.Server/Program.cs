using App.Model;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<Greeter>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/greet", (Greeter greeter) => greeter.Greet);

app.Run();
