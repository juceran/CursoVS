using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesWebMvc.Models;

namespace SalesWebMvc.ContextFluentAPI
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> modelBuilder)
        {
            /*  
               modelBuilder
                    .Property(p => p.Database)
                    .HasColumnType("varchar(64)");
               modelBuilder
                   .Property(p => p.CNPJ)
                   .HasColumnType("varchar(16)");
               modelBuilder
                   .Property(p => p.IE)
                   .HasColumnType("varchar(64)");
               modelBuilder
                   .Property(p => p.RazaoSocial)
                   .HasColumnType("varchar(64)");
               modelBuilder
                   .Property(p => p.Fantasia)
                   .HasColumnType("varchar(64)");
               modelBuilder
                   .Property(p => p.DataAbertura)
                   .HasColumnType("date");
               modelBuilder
                   .Property(p => p.Email)
                   .HasColumnType("varchar(128)");
               modelBuilder
                   .Property(p => p.Website)
                   .HasColumnType("varchar(128)");
               modelBuilder
                   .Property(p => p.CEP)
                   .HasColumnType("varchar(8)");
           */
            //campos comuns
            modelBuilder
                .Property(p => p.Ativo)
                .HasDefaultValue(true);
            modelBuilder
                .Property(p => p.DataCadastro)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.UltimaAtualizacao)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValue(DateTime.Now);
            modelBuilder
                .Property(p => p.Deletado)
                .HasDefaultValue(false);
            modelBuilder
                .Property(p => p.DeletadoData)
                .HasColumnType("TIMESTAMP");

            modelBuilder
                .HasData(new Empresa {
                    Id = 1,
                    Database = "Comum",
                    CNPJ = "70000401000127",
                    IE = "ISENTO",
                    RazaoSocial = "JUCERAN CAVALCANTE ME",
                    Fantasia = "CETASISTEMAS",
                    DataAbertura = DateTime.Parse("18/01/1994"),
                    Website = "www.cetasistemas.com.br",
                    Email = "juceran@gmail.com",
                    CEP = "57046055",
                    Uf = "AL",
                    Bairro = "SERRARIA",
                    Ativo = true,
                    DataCadastro = DateTime.Now

                });
        }
    }
}
