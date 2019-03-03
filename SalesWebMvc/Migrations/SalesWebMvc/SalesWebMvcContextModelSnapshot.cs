﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SalesWebMvc.Context;

namespace SalesWebMvc.Migrations.SalesWebMvc
{
    [DbContext(typeof(SalesWebMvcContext))]
    partial class SalesWebMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SalesWebMvc.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 277, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 278, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Departamento");
                });

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
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 275, DateTimeKind.Local));

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
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 276, DateTimeKind.Local));

                    b.Property<string>("Unidade")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Website")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("SalesWebMvc.Models.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("BaixaLancamento")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("CartaoCredito")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("CartaoCreditoMelhorDia");

                    b.Property<int>("CartaoCreditoVencimento");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("EmpresaId");

                    b.Property<int>("FormaPagamentoTipo");

                    b.Property<bool>("GeraFinanceiro")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("EmpresaId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("Cliente")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("FormaRecebimentoId");

                    b.Property<decimal?>("LimiteCredito");

                    b.Property<int>("PessoaId");

                    b.Property<int>("PrazoRecebimentoId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("FormaRecebimentoId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.HasIndex("PrazoRecebimentoId");

                    b.ToTable("PessoaCliente");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Emails")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<int>("Tipo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaEmail");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CEP")
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<DateTime?>("DeletadoData");

                    b.Property<bool>("Endereco");

                    b.Property<int>("EnderecoTipo");

                    b.Property<string>("GIA")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IBGE")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Localidade")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(64)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<DateTime?>("UltimaAtualizacao");

                    b.Property<string>("Unidade")
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaEndereco");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaFisica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("CPF")
                        .HasColumnType("varchar(16)");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local));

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("Date");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("Fisica")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Mae")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Pai")
                        .HasColumnType("varchar(128)");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RG")
                        .HasColumnType("varchar(64)");

                    b.Property<int?>("Sexo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaFisica");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaFornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("FormaPagamentoId");

                    b.Property<bool>("Fornecedor")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<int>("PrazoPagamentoId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("FormaPagamentoId");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.HasIndex("PrazoPagamentoId");

                    b.ToTable("PessoaFornecedor");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaJuridica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("CNPJ")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("Complemento");

                    b.Property<DateTime?>("DataAbertura")
                        .HasColumnType("Date");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local));

                    b.Property<DateTime?>("DataSituacao")
                        .HasColumnType("Date");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Fantasia")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("IE")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("Juridica")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("MotivoSituacao");

                    b.Property<int>("PessoaId");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Situacao")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaJuridica");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<bool>("Fone")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("PessoaId");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<int>("Tipo");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaTelefone");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<int>("PessoaId");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local));

                    b.Property<bool>("User")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Usuario")
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId")
                        .IsUnique();

                    b.ToTable("PessoaUsuario");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaUsuarioSenha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("DataCadastro");

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData");

                    b.Property<int>("PessoaUsuarioId");

                    b.Property<string>("Senha")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("UltimaAtualizacao");

                    b.HasKey("Id");

                    b.HasIndex("PessoaUsuarioId")
                        .IsUnique();

                    b.ToTable("PessoaUsuarioSenha");
                });

            modelBuilder.Entity("SalesWebMvc.Models.PrazoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<bool>("BaixaLancamento");

                    b.Property<DateTime?>("DataCadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local));

                    b.Property<bool>("Deletado")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("DeletadoData")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("DiasParcela");

                    b.Property<int>("EmpresaId");

                    b.Property<decimal>("Limite");

                    b.Property<int>("Parcelas");

                    b.Property<decimal>("PrazoMedio");

                    b.Property<int>("PrazoPagamentoTipo");

                    b.Property<int>("PrimeiraParcela");

                    b.Property<DateTime?>("UltimaAtualizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIMESTAMP")
                        .HasDefaultValue(new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local));

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("PrazoPagamento");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Departamento", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.FormaPagamento", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.Pessoa", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaCliente", b =>
                {
                    b.HasOne("SalesWebMvc.Models.FormaPagamento", "FormaRecebimento")
                        .WithMany()
                        .HasForeignKey("FormaRecebimentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaCliente")
                        .HasForeignKey("SalesWebMvc.Models.PessoaCliente", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.PrazoPagamento", "PrazoRecebimento")
                        .WithMany()
                        .HasForeignKey("PrazoRecebimentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaEmail", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaEmail")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaEndereco", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaEndereco")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaFisica", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaFisica")
                        .HasForeignKey("SalesWebMvc.Models.PessoaFisica", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaFornecedor", b =>
                {
                    b.HasOne("SalesWebMvc.Models.FormaPagamento", "FormaPagamento")
                        .WithMany()
                        .HasForeignKey("FormaPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaFornecedor")
                        .HasForeignKey("SalesWebMvc.Models.PessoaFornecedor", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesWebMvc.Models.PrazoPagamento", "PrazoPagamento")
                        .WithMany()
                        .HasForeignKey("PrazoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaJuridica", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaJuridica")
                        .HasForeignKey("SalesWebMvc.Models.PessoaJuridica", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaTelefone", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithMany("PessoaTelefone")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaUsuario", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Pessoa", "Pessoa")
                        .WithOne("PessoaUsuario")
                        .HasForeignKey("SalesWebMvc.Models.PessoaUsuario", "PessoaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PessoaUsuarioSenha", b =>
                {
                    b.HasOne("SalesWebMvc.Models.PessoaUsuario", "PessoaUsuario")
                        .WithOne("PessoaUsuarioSenha")
                        .HasForeignKey("SalesWebMvc.Models.PessoaUsuarioSenha", "PessoaUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesWebMvc.Models.PrazoPagamento", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
