using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_API.Migrations
{
    public partial class alterclienttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    nome = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    cpf = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    rg = table.Column<string>(type: "VARCHAR(25)", maxLength: 25, nullable: true),
                    data_expedicao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orgao_expedicao_value = table.Column<int>(type: "int", nullable: false),
                    orgao_expedicao_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo_value = table.Column<int>(type: "int", nullable: false),
                    sexo_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado_civil_value = table.Column<int>(type: "int", nullable: false),
                    estado_civil_desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "endereco_cliente",
                columns: table => new
                {
                    id_endereco_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    cep = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    numero = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    complemento = table.Column<string>(type: "VARCHAR(1000)", maxLength: 1000, nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    rua = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    cidade = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: true),
                    uf_value = table.Column<int>(type: "int", nullable: false),
                    uf_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco_cliente", x => x.id_endereco_cliente);
                    table.ForeignKey(
                        name: "FK_endereco_cliente_cliente_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "cliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_cliente_id_cliente",
                table: "endereco_cliente",
                column: "id_cliente",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "endereco_cliente");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
