﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;
using System;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaTelefoneConfiguration : IEntityTypeConfiguration<PessoaTelefone>
    {
        public void Configure(EntityTypeBuilder<PessoaTelefone> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Fone)
                .HasDefaultValue(false);
            //campos comuns
            modelBuilder
                .Property(p => p.Ativo)
                .HasDefaultValue(true);
            modelBuilder
                .Property(p => p.Deletado)
                .HasDefaultValue(false);
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
        }
    }
}
