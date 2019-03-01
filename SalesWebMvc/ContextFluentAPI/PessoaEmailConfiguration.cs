using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;
using System;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaEmailConfiguration : IEntityTypeConfiguration<PessoaEmail>
    {
        public void Configure(EntityTypeBuilder<PessoaEmail> modelBuilder)
        {
            //campos comuns
            modelBuilder
                .Property(p => p.DataCadastro)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.UltimaAtualizacao)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.DeletadoData)
                .HasColumnType("TIMESTAMP");

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //        new PessoaEmail { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 1, Email = "juceran@gmail.com", Tipo = Models.Enums.EmailTipo.pessoal         },
            //        new PessoaEmail { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaId = 2, Email = "diretoria@intimesoft.com.br", Tipo = Models.Enums.EmailTipo.comercial }
            //        );
        }
    }
}
