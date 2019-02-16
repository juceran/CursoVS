using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaJuridicaConfiguration : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> modelBuilder)
        {
            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(pj => pj.PessoaJuridica)
                .HasForeignKey<Pessoa>(p => p.Id);
        }
    }
}
