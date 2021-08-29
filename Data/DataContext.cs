using BananaVerdeProdutosNaturais.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace BananaVerdeProdutosNaturais.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    
        public DbSet<Product> Products { get; set; }

    }
}