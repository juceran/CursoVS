﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesWebMvc.Migrations.SalesWebMvc
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Database = table.Column<string>(type: "varchar(64)", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(16)", nullable: true),
                    IE = table.Column<string>(type: "varchar(32)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(64)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "Date", nullable: true),
                    Email = table.Column<string>(type: "varchar(64)", nullable: true),
                    Website = table.Column<string>(type: "varchar(64)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(64)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(64)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(128)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(64)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(64)", nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: false, defaultValue: "AL"),
                    Unidade = table.Column<string>(type: "varchar(16)", nullable: true),
                    IBGE = table.Column<string>(type: "varchar(16)", nullable: true),
                    GIA = table.Column<string>(type: "varchar(64)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Nome = table.Column<string>(type: "varchar(64)", nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamento_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(64)", nullable: false),
                    GeraFinanceiro = table.Column<bool>(nullable: false, defaultValue: true),
                    BaixaLancamento = table.Column<bool>(nullable: false, defaultValue: false),
                    CartaoCredito = table.Column<bool>(nullable: false, defaultValue: false),
                    CartaoCreditoVencimento = table.Column<int>(nullable: false),
                    CartaoCreditoMelhorDia = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    FormaPagamentoTipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormaPagamento_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(64)", nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrazoPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 503, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 504, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(64)", nullable: false),
                    Parcelas = table.Column<int>(nullable: false),
                    PrimeiraParcela = table.Column<int>(nullable: false),
                    DiasParcela = table.Column<int>(nullable: false),
                    Limite = table.Column<decimal>(nullable: false),
                    PrazoMedio = table.Column<decimal>(nullable: false),
                    BaixaLancamento = table.Column<bool>(nullable: false),
                    PrazoPagamentoTipo = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrazoPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrazoPagamento_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioPermissaoAcesso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Visualizar = table.Column<bool>(nullable: false, defaultValue: false),
                    Incluir = table.Column<bool>(nullable: false, defaultValue: false),
                    Editar = table.Column<bool>(nullable: false, defaultValue: false),
                    Imprimir = table.Column<bool>(nullable: false, defaultValue: false),
                    Baixar = table.Column<bool>(nullable: false, defaultValue: false),
                    Cancelar = table.Column<bool>(nullable: false, defaultValue: false),
                    CancelarBaixa = table.Column<bool>(nullable: false, defaultValue: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioPermissaoAcesso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioPermissaoAcesso_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Emails = table.Column<bool>(nullable: false, defaultValue: false),
                    Email = table.Column<string>(type: "varchar(64)", nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaEmail_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaEndereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Endereco = table.Column<bool>(nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(64)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(128)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(64)", nullable: false),
                    Localidade = table.Column<string>(type: "varchar(64)", nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: false),
                    Unidade = table.Column<string>(type: "varchar(16)", nullable: true),
                    IBGE = table.Column<string>(type: "varchar(16)", nullable: true),
                    GIA = table.Column<string>(type: "varchar(64)", nullable: true),
                    EnderecoTipo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaEndereco_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Fisica = table.Column<bool>(nullable: false, defaultValue: false),
                    Nome = table.Column<string>(type: "varchar(128)", nullable: true),
                    Pai = table.Column<string>(type: "varchar(128)", nullable: true),
                    Mae = table.Column<string>(type: "varchar(128)", nullable: true),
                    CPF = table.Column<string>(type: "varchar(16)", nullable: true),
                    RG = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: true),
                    Sexo = table.Column<int>(nullable: true),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Juridica = table.Column<bool>(nullable: false, defaultValue: false),
                    CNPJ = table.Column<string>(type: "varchar(16)", nullable: true),
                    IE = table.Column<string>(type: "varchar(64)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(64)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "Date", nullable: true),
                    Situacao = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataSituacao = table.Column<DateTime>(type: "Date", nullable: true),
                    MotivoSituacao = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaTelefone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Fone = table.Column<bool>(nullable: false, defaultValue: false),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaTelefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaTelefone_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaCliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Cliente = table.Column<bool>(nullable: false, defaultValue: false),
                    LimiteCredito = table.Column<decimal>(nullable: true),
                    PessoaId = table.Column<int>(nullable: false),
                    FormaRecebimentoId = table.Column<int>(nullable: false),
                    PrazoRecebimentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaCliente_FormaPagamento_FormaRecebimentoId",
                        column: x => x.FormaRecebimentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaCliente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaCliente_PrazoPagamento_PrazoRecebimentoId",
                        column: x => x.PrazoRecebimentoId,
                        principalTable: "PrazoPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Fornecedor = table.Column<bool>(nullable: false, defaultValue: false),
                    PessoaId = table.Column<int>(nullable: false),
                    FormaPagamentoId = table.Column<int>(nullable: false),
                    PrazoPagamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFornecedor_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaFornecedor_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaFornecedor_PrazoPagamento_PrazoPagamentoId",
                        column: x => x.PrazoPagamentoId,
                        principalTable: "PrazoPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuUl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Menu = table.Column<string>(type: "varchar(128)", nullable: true),
                    Url = table.Column<string>(type: "varchar(256)", nullable: true),
                    UsuarioPermissaoAcessoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuUl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuUl_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                        column: x => x.UsuarioPermissaoAcessoId,
                        principalTable: "UsuarioPermissaoAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    User = table.Column<bool>(nullable: false, defaultValue: false),
                    Usuario = table.Column<string>(type: "varchar(64)", nullable: true),
                    PessoaId = table.Column<int>(nullable: false),
                    UsuarioPermissaoAcessoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaUsuario_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaUsuario_UsuarioPermissaoAcesso_UsuarioPermissaoAcesso~",
                        column: x => x.UsuarioPermissaoAcessoId,
                        principalTable: "UsuarioPermissaoAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenuLi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    SubMenu = table.Column<string>(type: "varchar(128)", nullable: true),
                    Url = table.Column<string>(type: "varchar(256)", nullable: true),
                    Titulo = table.Column<string>(type: "varchar(128)", nullable: true),
                    MenuUlId = table.Column<int>(nullable: false),
                    UsuarioPermissaoAcessoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuLi_MenuUl_MenuUlId",
                        column: x => x.MenuUlId,
                        principalTable: "MenuUl",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuLi_UsuarioPermissaoAcesso_UsuarioPermissaoAcessoId",
                        column: x => x.UsuarioPermissaoAcessoId,
                        principalTable: "UsuarioPermissaoAcesso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaUsuarioSenha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Senha = table.Column<string>(type: "varchar(128)", maxLength: 10, nullable: true),
                    PessoaUsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaUsuarioSenha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaUsuarioSenha_PessoaUsuario_PessoaUsuarioId",
                        column: x => x.PessoaUsuarioId,
                        principalTable: "PessoaUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Ativo", "Bairro", "CEP", "CNPJ", "Cidade", "Complemento", "DataAbertura", "DataCadastro", "Database", "Deletado", "DeletadoData", "Email", "Fantasia", "GIA", "IBGE", "IE", "Logradouro", "Numero", "RazaoSocial", "Uf", "UltimaAtualizacao", "Unidade", "Website" },
                values: new object[] { 1, true, "SERRARIA", "57046055", "70000401000127", null, null, new DateTime(1994, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 9, 9, 44, 2, 500, DateTimeKind.Local), "Comum", false, null, "juceran@gmail.com", "CETASISTEMAS", null, null, "ISENTO", null, null, "JUCERAN CAVALCANTE ME", "AL", null, null, "www.cetasistemas.com.br" });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Ativo", "Bairro", "CEP", "CNPJ", "Cidade", "Complemento", "DataAbertura", "DataCadastro", "Database", "Deletado", "DeletadoData", "Email", "Fantasia", "GIA", "IBGE", "IE", "Logradouro", "Numero", "RazaoSocial", "Uf", "UltimaAtualizacao", "Unidade", "Website" },
                values: new object[] { 2, true, "TABULEIRO DO MARTINS", "57081000", "21373332000191", null, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 9, 9, 44, 2, 500, DateTimeKind.Local), "SalesWebMvc", false, null, "alexlamanda@gmail.com", "3R AMBIENTAL", null, null, "", null, null, "3R INDÚSTRIA E COMÉRCIO DE PLÁSTICO LTDA - ME", "AL", null, null, "" });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_EmpresaId",
                table: "Departamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamento_EmpresaId",
                table: "FormaPagamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuLi_MenuUlId",
                table: "MenuLi",
                column: "MenuUlId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuLi_UsuarioPermissaoAcessoId",
                table: "MenuLi",
                column: "UsuarioPermissaoAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuUl_UsuarioPermissaoAcessoId",
                table: "MenuUl",
                column: "UsuarioPermissaoAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmpresaId",
                table: "Pessoa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_FormaRecebimentoId",
                table: "PessoaCliente",
                column: "FormaRecebimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_PessoaId",
                table: "PessoaCliente",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_PrazoRecebimentoId",
                table: "PessoaCliente",
                column: "PrazoRecebimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEmail_PessoaId",
                table: "PessoaEmail",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEndereco_PessoaId",
                table: "PessoaEndereco",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_PessoaId",
                table: "PessoaFisica",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFornecedor_FormaPagamentoId",
                table: "PessoaFornecedor",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFornecedor_PessoaId",
                table: "PessoaFornecedor",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFornecedor_PrazoPagamentoId",
                table: "PessoaFornecedor",
                column: "PrazoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_PessoaId",
                table: "PessoaJuridica",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaTelefone_PessoaId",
                table: "PessoaTelefone",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaUsuario_PessoaId",
                table: "PessoaUsuario",
                column: "PessoaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PessoaUsuario_UsuarioPermissaoAcessoId",
                table: "PessoaUsuario",
                column: "UsuarioPermissaoAcessoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaUsuarioSenha_PessoaUsuarioId",
                table: "PessoaUsuarioSenha",
                column: "PessoaUsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrazoPagamento_EmpresaId",
                table: "PrazoPagamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioPermissaoAcesso_EmpresaId",
                table: "UsuarioPermissaoAcesso",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "MenuLi");

            migrationBuilder.DropTable(
                name: "PessoaCliente");

            migrationBuilder.DropTable(
                name: "PessoaEmail");

            migrationBuilder.DropTable(
                name: "PessoaEndereco");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaFornecedor");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "PessoaTelefone");

            migrationBuilder.DropTable(
                name: "PessoaUsuarioSenha");

            migrationBuilder.DropTable(
                name: "MenuUl");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "PrazoPagamento");

            migrationBuilder.DropTable(
                name: "PessoaUsuario");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "UsuarioPermissaoAcesso");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
