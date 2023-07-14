using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteJSL.Migrations
{
    /// <inheritdoc />
    public partial class TestJSLInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ativo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ValorProduto = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Ativo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IdCliente = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    DataPedido = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TotalPedido = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbPedido_tbCliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tbCliente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbPedidoProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    IdPedido = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IdProduto = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Quantidade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ValorProduto = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    ValorTotal = table.Column<float>(type: "BINARY_FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPedidoProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbPedidoProdutos_tbProduto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "tbProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbPedido_ClienteId",
                table: "tbPedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tbPedidoProdutos_IdProduto",
                table: "tbPedidoProdutos",
                column: "IdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbPedido");

            migrationBuilder.DropTable(
                name: "tbPedidoProdutos");

            migrationBuilder.DropTable(
                name: "tbCliente");

            migrationBuilder.DropTable(
                name: "tbProduto");
        }
    }
}
