using GaleriaDeImagens1.Models;
using Microsoft.EntityFrameworkCore;

namespace GaleriaDeImagens1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<ImagemModel> Imagem { get; set; }
    }
}
