﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;
using System;

namespace SalesWebMvc.ContextFluentAPI
{
    public class PessoaClienteConfiguration : IEntityTypeConfiguration<PessoaCliente>
    {
        public void Configure(EntityTypeBuilder<PessoaCliente> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Cliente)
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

            //relacionamento 1 para 1
            modelBuilder
                .HasOne(p => p.Pessoa)
                .WithOne(p => p.PessoaCliente)
                .HasForeignKey<PessoaCliente>(p => p.PessoaId);

            /* Inserir dados no banco */
            //modelBuilder
            //    .HasData(
            //    new PessoaCliente { Id = 1, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Cliente = true, PessoaId = 1, LimiteCredito = 500 },
            //    new PessoaCliente { Id = 2, Ativo = true, DataCadastro = DateTime.Now, UltimaAtualizacao = DateTime.Now, Deletado = false, Cliente = true, PessoaId = 2, LimiteCredito = 500 }
            //    );
        }
    }
}
