using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class RelacionamentoPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PessoaFisicaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "PessoaFornecedorId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "PessoaJuridicaId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "PessoaUsuarioId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 276, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 32, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 276, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 32, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 274, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 29, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 274, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 29, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 272, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 26, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 272, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 26, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 269, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 23, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 269, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 23, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 266, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 20, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 266, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 20, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 264, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 17, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 264, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 17, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 260, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 13, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 259, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 12, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 263, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 16, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 262, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 16, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 2, 21, 22, 5, 2, 263, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 2, 21, 22, 5, 2, 261, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 32, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 276, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 32, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 276, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 29, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 274, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 29, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 274, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 26, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 272, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 26, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 272, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 23, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 269, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 23, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 269, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 20, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 266, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 20, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 266, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 17, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 264, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 17, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 264, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "PessoaFisicaId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaFornecedorId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaJuridicaId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PessoaUsuarioId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 13, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 260, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 12, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 259, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 16, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 263, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 2, 21, 21, 53, 55, 16, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 2, 21, 22, 5, 2, 262, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 2, 21, 21, 53, 55, 16, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Empresa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2019, 2, 21, 21, 53, 55, 14, DateTimeKind.Local));
        }
    }
}
