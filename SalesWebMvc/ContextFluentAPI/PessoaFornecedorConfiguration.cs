using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaFornecedorConfiguration : IEntityTypeConfiguration<PessoaFornecedor>
    {
        public void Configure(EntityTypeBuilder<PessoaFornecedor> modelBuilder)
        {
            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(pc => pc.PessoaFornecedor)
                .HasForeignKey<Pessoa>(p => p.Id);
        }
    }
}
