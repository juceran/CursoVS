using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations.SalesWebMvc
{
    public partial class Bandeiracartaodecredito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 689, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 689, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 671, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 504, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 671, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 503, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 686, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 686, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 684, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 684, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 683, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 683, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 680, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 680, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 677, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 677, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 679, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 679, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 674, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 674, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 672, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 672, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "MenuUl",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 690, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "MenuUl",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 690, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "MenuLi",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "MenuLi",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 692, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 670, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 670, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "CartaoDeCredito",
                table: "FormaPagamento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 666, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local));

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Empresa",
                nullable: false,
                defaultValue: "AL",
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldDefaultValue: "AL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 665, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 668, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 668, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 3, 11, 19, 50, 35, 667, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2019, 3, 11, 19, 50, 35, 667, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartaoDeCredito",
                table: "FormaPagamento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 689, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "UsuarioPermissaoAcesso",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 520, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 689, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 504, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 671, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 503, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 671, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 686, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 517, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 686, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 684, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 516, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 684, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 683, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 514, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 683, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 680, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 512, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 680, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 677, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 509, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 677, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 679, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 510, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 679, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 674, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 506, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 674, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 672, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 505, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 672, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "MenuUl",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 690, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "MenuUl",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 521, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 690, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "MenuLi",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "MenuLi",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 523, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 692, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 670, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 502, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 670, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 666, DateTimeKind.Local));

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Empresa",
                maxLength: 2,
                nullable: false,
                defaultValue: "AL",
                oldClrType: typeof(string),
                oldDefaultValue: "AL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 498, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 665, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 668, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 9, 9, 44, 2, 501, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 11, 19, 50, 35, 668, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 3, 9, 9, 44, 2, 500, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2019, 3, 9, 9, 44, 2, 500, DateTimeKind.Local));
        }
    }
}
