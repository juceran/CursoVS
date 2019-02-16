using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaFisicaConfiguration : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> modelBuilder)
        {
            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(pc => pc.PessoaFisica)
                .HasForeignKey<Pessoa>(p => p.Id);
        }
    }
}
