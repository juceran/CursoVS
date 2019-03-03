using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations.SalesWebMvc
{
    public partial class prazoderecebimentosmelhorado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCliente_FormaPagamento_FormaPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCliente_PrazoPagamento_PrazoPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.DropIndex(
                name: "IX_PessoaCliente_FormaPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.DropIndex(
                name: "IX_PessoaCliente_PrazoPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.DropColumn(
                name: "FormaPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.DropColumn(
                name: "PrazoPagamentoId",
                table: "PessoaCliente");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 270, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 270, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 285, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 285, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 283, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 283, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 282, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 282, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 280, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 280, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 276, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 276, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 278, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 278, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 274, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 274, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 272, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 272, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 265, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 265, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 276, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 262, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 275, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 261, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 278, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 263, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 277, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 263, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_FormaRecebimentoId",
                table: "PessoaCliente",
                column: "FormaRecebimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_PrazoRecebimentoId",
                table: "PessoaCliente",
                column: "PrazoRecebimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCliente_FormaPagamento_FormaRecebimentoId",
                table: "PessoaCliente",
                column: "FormaRecebimentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCliente_PrazoPagamento_PrazoRecebimentoId",
                table: "PessoaCliente",
                column: "PrazoRecebimentoId",
                principalTable: "PrazoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCliente_FormaPagamento_FormaRecebimentoId",
                table: "PessoaCliente");

            migrationBuilder.DropForeignKey(
                name: "FK_PessoaCliente_PrazoPagamento_PrazoRecebimentoId",
                table: "PessoaCliente");

            migrationBuilder.DropIndex(
                name: "IX_PessoaCliente_FormaRecebimentoId",
                table: "PessoaCliente");

            migrationBuilder.DropIndex(
                name: "IX_PessoaCliente_PrazoRecebimentoId",
                table: "PessoaCliente");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 270, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PrazoPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 270, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 280, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 285, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaUsuario",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 285, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 295, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaTelefone",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 283, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 293, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 282, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaJuridica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 282, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 292, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 280, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFornecedor",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 280, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 290, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 276, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaFisica",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 276, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 286, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 278, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaEmail",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 278, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 288, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 274, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "PessoaCliente",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 274, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 283, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "FormaPagamentoId",
                table: "PessoaCliente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrazoPagamentoId",
                table: "PessoaCliente",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 272, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Pessoa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 272, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 282, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 265, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "FormaPagamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 265, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 279, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 262, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 276, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Empresa",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 261, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 275, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UltimaAtualizacao",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 263, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 278, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCadastro",
                table: "Departamento",
                type: "TIMESTAMP",
                nullable: true,
                defaultValue: new DateTime(2019, 3, 2, 23, 24, 22, 263, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 3, 2, 23, 28, 12, 277, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_FormaPagamentoId",
                table: "PessoaCliente",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_PrazoPagamentoId",
                table: "PessoaCliente",
                column: "PrazoPagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCliente_FormaPagamento_FormaPagamentoId",
                table: "PessoaCliente",
                column: "FormaPagamentoId",
                principalTable: "FormaPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaCliente_PrazoPagamento_PrazoPagamentoId",
                table: "PessoaCliente",
                column: "PrazoPagamentoId",
                principalTable: "PrazoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
