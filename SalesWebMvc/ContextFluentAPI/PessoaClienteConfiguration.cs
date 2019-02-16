using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaClienteConfiguration : IEntityTypeConfiguration<PessoaCliente>
    {
        public void Configure(EntityTypeBuilder<PessoaCliente> modelBuilder)
        {
            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(pc => pc.PessoaCliente)
                .HasForeignKey<Pessoa>(p => p.Id);
        }
    }
}
