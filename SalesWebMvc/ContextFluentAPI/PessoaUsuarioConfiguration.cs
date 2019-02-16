using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaUsuarioConfiguration : IEntityTypeConfiguration<PessoaUsuario>
    {
        public void Configure(EntityTypeBuilder<PessoaUsuario> modelBuilder)
        {
            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(pu => pu.PessoaUsuario)
                .HasForeignKey<Pessoa>(p => p.Id);
        }
    }
}
