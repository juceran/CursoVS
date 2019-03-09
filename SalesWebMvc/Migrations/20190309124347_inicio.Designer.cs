﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesWebMvc.Context;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(ComumContext))]
    [Migration("20190309124347_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SalesWebMvc.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("DataAbertura")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 9, 9, 43, 47, 77, DateTimeKind.Local));

                    b.Property<string>("Database")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Fantasia")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("GIA")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IBGE")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("IE")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasDefaultValue("AL");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 9, 9, 43, 47, 98, DateTimeKind.Local));

                    b.Property<string>("Unidade")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Website")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");

                    b.HasData(
                        new { Id = 1, Ativo = true, Bairro = "SERRARIA", CEP = "57046055", CNPJ = "70000401000127", DataAbertura = new DateTime(1994, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), DataCadastro = new DateTime(2019, 3, 9, 9, 43, 47, 109, DateTimeKind.Local), Database = "Comum", Deletado = false, Email = "juceran@gmail.com", Fantasia = "CETASISTEMAS", IE = "ISENTO", RazaoSocial = "JUCERAN CAVALCANTE ME", Uf = "AL", Website = "www.cetasistemas.com.br" },
                        new { Id = 2, Ativo = true, Bairro = "TABULEIRO DO MARTINS", CEP = "57081000", CNPJ = "21373332000191", DataAbertura = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), DataCadastro = new DateTime(2019, 3, 9, 9, 43, 47, 109, DateTimeKind.Local), Database = "SalesWebMvc", Deletado = false, Email = "alexlamanda@gmail.com", Fantasia = "3R AMBIENTAL", IE = "", RazaoSocial = "3R INDÚSTRIA E COMÉRCIO DE PLÁSTICO LTDA - ME", Uf = "AL", Website = "" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
