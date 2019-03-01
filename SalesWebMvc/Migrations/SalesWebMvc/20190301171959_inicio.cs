using System;
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 464, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 465, DateTimeKind.Local)),
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 466, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 466, DateTimeKind.Local)),
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 468, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 468, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(64)", nullable: false),
                    GeraFinanceiro = table.Column<bool>(nullable: false, defaultValue: true),
                    BaixaLancamento = table.Column<bool>(nullable: false, defaultValue: false),
                    CartaoCredito = table.Column<bool>(nullable: false, defaultValue: false),
                    CartaoCreditoVencimento = table.Column<int>(nullable: false),
                    CartaoCreditoMelhorDia = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 469, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 469, DateTimeKind.Local)),
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
                name: "PessoaCliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 471, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 471, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Cliente = table.Column<bool>(nullable: true),
                    LimiteCredito = table.Column<decimal>(nullable: true),
                    PessoaId = table.Column<int>(nullable: false),
                    FormaPagamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaCliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaCliente_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaCliente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 474, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 474, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 473, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 473, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
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
                name: "PessoaFornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 476, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 476, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Fornecedor = table.Column<bool>(nullable: false),
                    PessoaId = table.Column<int>(nullable: false),
                    FormaPagamentoId = table.Column<int>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 478, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 478, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
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
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 480, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 480, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
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
                name: "PessoaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Ativo = table.Column<bool>(nullable: false, defaultValue: true),
                    DataCadastro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 481, DateTimeKind.Local)),
                    UltimaAtualizacao = table.Column<DateTime>(type: "TIMESTAMP", nullable: true, defaultValue: new DateTime(2019, 3, 1, 14, 19, 59, 482, DateTimeKind.Local)),
                    Deletado = table.Column<bool>(nullable: false, defaultValue: false),
                    DeletadoData = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Usuario = table.Column<string>(type: "varchar(64)", nullable: true),
                    PessoaId = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_EmpresaId",
                table: "Departamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormaPagamento_EmpresaId",
                table: "FormaPagamento",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmpresaId",
                table: "Pessoa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_FormaPagamentoId",
                table: "PessoaCliente",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaCliente_PessoaId",
                table: "PessoaCliente",
                column: "PessoaId",
                unique: true);

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
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "PessoaUsuario");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
