using Microsoft.EntityFrameworkCore;
using SalesWebMvc.ContextFluentAPI;
using SalesWebMvc.Models;

namespace SalesWebMvc.Context
{
    public class ComumContext : DbContext
    {
        public ComumContext()
        {
        }

        public ComumContext(DbContextOptions<ComumContext> options)
            : base(options)
        {

        }

        public DbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaConfiguration());
        }
   
    }
}