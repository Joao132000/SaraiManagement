using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaraiManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caixas",
                columns: table => new
                {
                    CaixaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caixas", x => x.CaixaID);
                });

            migrationBuilder.CreateTable(
                name: "Doadors",
                columns: table => new
                {
                    DoadorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    regularidadeDoador = table.Column<int>(type: "int", nullable: false),
                    inicioDaDoacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doadors", x => x.DoadorID);
                });

            migrationBuilder.CreateTable(
                name: "Donatarios",
                columns: table => new
                {
                    DonatarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donatarios", x => x.DonatarioID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Escola = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeResponsavel = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Período = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Admissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonatarioID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoID);
                    table.ForeignKey(
                        name: "FK_Alunos_Donatarios_DonatarioID",
                        column: x => x.DonatarioID,
                        principalTable: "Donatarios",
                        principalColumn: "DonatarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doacaos",
                columns: table => new
                {
                    DoacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonatarioID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    UsuarioID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doacaos", x => x.DoacaoID);
                    table.ForeignKey(
                        name: "FK_Doacaos_Donatarios_DonatarioID",
                        column: x => x.DonatarioID,
                        principalTable: "Donatarios",
                        principalColumn: "DonatarioID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doacaos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacaos",
                columns: table => new
                {
                    MovimentacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: false),
                    CaixaID = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    TipoMovimentacao = table.Column<int>(type: "int", nullable: false),
                    DiaMovimentacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacaos", x => x.MovimentacaoID);
                    table.ForeignKey(
                        name: "FK_Movimentacaos_Caixas_CaixaID",
                        column: x => x.CaixaID,
                        principalTable: "Caixas",
                        principalColumn: "CaixaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movimentacaos_Usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDoados",
                columns: table => new
                {
                    ItemDoadoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    DoacaoID = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataValidade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDoados", x => x.ItemDoadoID);
                    table.ForeignKey(
                        name: "FK_ItemDoados_Doacaos_DoacaoID",
                        column: x => x.DoacaoID,
                        principalTable: "Doacaos",
                        principalColumn: "DoacaoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_DonatarioID",
                table: "Alunos",
                column: "DonatarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doacaos_DonatarioID",
                table: "Doacaos",
                column: "DonatarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Doacaos_UsuarioID",
                table: "Doacaos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDoados_DoacaoID",
                table: "ItemDoados",
                column: "DoacaoID");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacaos_CaixaID",
                table: "Movimentacaos",
                column: "CaixaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacaos_UsuarioID",
                table: "Movimentacaos",
                column: "UsuarioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Doadors");

            migrationBuilder.DropTable(
                name: "ItemDoados");

            migrationBuilder.DropTable(
                name: "Movimentacaos");

            migrationBuilder.DropTable(
                name: "Doacaos");

            migrationBuilder.DropTable(
                name: "Caixas");

            migrationBuilder.DropTable(
                name: "Donatarios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
