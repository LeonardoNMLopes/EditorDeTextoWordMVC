using Microsoft.EntityFrameworkCore;
using WordProjetoMVC.Models;

namespace WordProjetoMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        public DbSet<Documento> Documentos { get; set; }
    }
}
