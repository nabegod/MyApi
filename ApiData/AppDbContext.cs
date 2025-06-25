using Microsoft.EntityFrameworkCore;
using MyApi.models;

namespace MyApi.ApiData;

public class AppDbContext : DbContext
{
    public DbSet<Api> Apis { get; set; }
    // Propriedades e métodos do contexto de banco de dados

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(connectionString:"Data Source=MyApi.db;Cache=Shared");
    }
}