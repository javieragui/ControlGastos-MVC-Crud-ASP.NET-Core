using ControlIngresoGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlIngresoGastos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<IngresoGasto> IngresoGastos { get; set; }
    }
}
