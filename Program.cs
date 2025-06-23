var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços de controladores
builder.Services.AddControllers();

var app = builder.Build();

// Usa o roteamento de controladores
app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
