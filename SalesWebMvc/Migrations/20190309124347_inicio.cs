﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesWebMvc.Migrations
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 43, 47, 77, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 9, 9, 43, 47, 98, DateTimeKind.Local)),
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

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Ativo", "Bairro", "CEP", "CNPJ", "Cidade", "Complemento", "DataAbertura", "DataCadastro", "Database", "Deletado", "DeletadoData", "Email", "Fantasia", "GIA", "IBGE", "IE", "Logradouro", "Numero", "RazaoSocial", "Uf", "UltimaAtualizacao", "Unidade", "Website" },
                values: new object[] { 1, true, "SERRARIA", "57046055", "70000401000127", null, null, new DateTime(1994, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 9, 9, 43, 47, 109, DateTimeKind.Local), "Comum", false, null, "juceran@gmail.com", "CETASISTEMAS", null, null, "ISENTO", null, null, "JUCERAN CAVALCANTE ME", "AL", null, null, "www.cetasistemas.com.br" });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Ativo", "Bairro", "CEP", "CNPJ", "Cidade", "Complemento", "DataAbertura", "DataCadastro", "Database", "Deletado", "DeletadoData", "Email", "Fantasia", "GIA", "IBGE", "IE", "Logradouro", "Numero", "RazaoSocial", "Uf", "UltimaAtualizacao", "Unidade", "Website" },
                values: new object[] { 2, true, "TABULEIRO DO MARTINS", "57081000", "21373332000191", null, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 9, 9, 43, 47, 109, DateTimeKind.Local), "SalesWebMvc", false, null, "alexlamanda@gmail.com", "3R AMBIENTAL", null, null, "", null, null, "3R INDÚSTRIA E COMÉRCIO DE PLÁSTICO LTDA - ME", "AL", null, null, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
