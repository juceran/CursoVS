using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc
{
    public class dboCommomContext : DbContext
    {
        public dboCommomContext(DbContextOptions<dboCommomContext> options)
            : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}