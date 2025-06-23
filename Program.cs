var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços de controladores
builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
