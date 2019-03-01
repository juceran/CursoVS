using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;
using System;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaUsuarioSenhaConfiguration : IEntityTypeConfiguration<PessoaUsuarioSenha>
    {
        public void Configure(EntityTypeBuilder<PessoaUsuarioSenha> modelBuilder)
        {
            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //        new PessoaUsuarioSenha { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaUsuarioId = 1, Senha = "1" },
            //        new PessoaUsuarioSenha { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, PessoaUsuarioId = 2, Senha = "1" }
            //        );

        }
    }
}
