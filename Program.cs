using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços de controladores
builder.Services.AddControllers();

// Adiciona o AppDbContext ao container de injeção de dependência
builder.Services.AddDbContext<MyApi.ApiData.AppDbContext>();

var app = builder.Build();


// Habilita os endpoints dos controllers
app.MapControllers();

app.Run();
