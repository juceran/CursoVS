using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SalesWebMvc.Migrations.Comum
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 2, 16, 8, 5, 59, 20, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Deletado = table.Column<bool>(nullable: true, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Database = table.Column<string>(type: "varchar(64)", nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(16)", nullable: true),
                    IE = table.Column<string>(type: "varchar(32)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(64)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "Date", nullable: false),
                    Email = table.Column<string>(type: "varchar(64)", nullable: true),
                    Website = table.Column<string>(type: "varchar(64)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(64)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(128)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(64)", nullable: true),
                    Localidade = table.Column<string>(type: "varchar(64)", nullable: true),
                    Uf = table.Column<string>(maxLength: 2, nullable: false),
                    Unidade = table.Column<string>(type: "varchar(16)", nullable: true),
                    IBGE = table.Column<string>(type: "varchar(16)", nullable: true),
                    GIA = table.Column<string>(type: "varchar(64)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaCliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 2, 16, 8, 5, 59, 27, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Deletado = table.Column<bool>(nullable: true, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Cliente = table.Column<bool>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    varchar128 = table.Column<string>(name: "varchar(128)", nullable: true),
                    Pai = table.Column<string>(type: "varchar(128)", nullable: true),
                    Mae = table.Column<string>(type: "varchar(128)", nullable: true),
                    CPF = table.Column<string>(type: "varchar(16)", nullable: true),
                    RG = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Fornecedor = table.Column<bool>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(16)", nullable: true),
                    IE = table.Column<string>(type: "varchar(64)", nullable: true),
                    RazaoSocial = table.Column<string>(type: "varchar(64)", nullable: true),
                    Fantasia = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataAbertura = table.Column<DateTime>(type: "Date", nullable: false),
                    Situacao = table.Column<string>(type: "varchar(64)", nullable: true),
                    DataSituacao = table.Column<DateTime>(type: "Date", nullable: false),
                    MotivoSituacao = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Usuario = table.Column<string>(type: "varchar(64)", nullable: true),
                    PessoaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaUsuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 2, 16, 8, 5, 59, 24, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Deletado = table.Column<bool>(nullable: true, defaultValue: false),
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
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 2, 16, 8, 5, 59, 26, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Deletado = table.Column<bool>(nullable: true, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(64)", nullable: false),
                    EmpresaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaCliente_Id",
                        column: x => x.Id,
                        principalTable: "PessoaCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaFisica_Id",
                        column: x => x.Id,
                        principalTable: "PessoaFisica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaFornecedor_Id",
                        column: x => x.Id,
                        principalTable: "PessoaFornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaJuridica_Id",
                        column: x => x.Id,
                        principalTable: "PessoaJuridica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaUsuario_Id",
                        column: x => x.Id,
                        principalTable: "PessoaUsuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaUsuarioSenha",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "PessoaEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(type: "varchar(64)", nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaEmail_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
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
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaEndereco_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaTelefone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: true),
                    DeletadoData = table.Column<DateTime>(nullable: true),
                    Telefone = table.Column<string>(type: "varchar(16)", nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaTelefone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaTelefone_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Ativo", "Bairro", "CEP", "CNPJ", "Complemento", "DataAbertura", "DataCadastro", "Database", "Deletado", "DeletadoData", "Email", "Fantasia", "GIA", "IBGE", "IE", "Localidade", "Logradouro", "RazaoSocial", "Uf", "UltimaAtualizacao", "Unidade", "Website" },
                values: new object[] { 1, true, "SERRARIA", "57046055", "70000401000127", null, new DateTime(1994, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 16, 8, 5, 59, 23, DateTimeKind.Local), "Comum", null, null, "juceran@gmail.com", "CETASISTEMAS", null, null, "ISENTO", null, null, "JUCERAN CAVALCANTE ME", "AL", null, null, "www.cetasistemas.com.br" });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "Id", "Ativo", "DataCadastro", "Deletado", "DeletadoData", "EmpresaId", "Nome", "UltimaAtualizacao" },
                values: new object[] { 1, true, new DateTime(2019, 2, 16, 8, 5, 59, 25, DateTimeKind.Local), null, null, 1, "RECURSOS HUMANOS", null });

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_EmpresaId",
                table: "Departamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmpresaId",
                table: "Pessoa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEmail_PessoaId",
                table: "PessoaEmail",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEndereco_PessoaId",
                table: "PessoaEndereco",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaTelefone_PessoaId",
                table: "PessoaTelefone",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaUsuarioSenha_PessoaUsuarioId",
                table: "PessoaUsuarioSenha",
                column: "PessoaUsuarioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "PessoaEmail");

            migrationBuilder.DropTable(
                name: "PessoaEndereco");

            migrationBuilder.DropTable(
                name: "PessoaTelefone");

            migrationBuilder.DropTable(
                name: "PessoaUsuarioSenha");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "PessoaCliente");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaFornecedor");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "PessoaUsuario");
        }
    }
}
