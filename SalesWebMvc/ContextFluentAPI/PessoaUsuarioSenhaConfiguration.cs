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

        }
    }
}
