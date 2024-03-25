using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEquipamento = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inventario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cadeado = table.Column<bool>(type: "bit", nullable: false),
                    RegistroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_Laboratorio",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CL_TipoEquipamento = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    CL_SerialNumber = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    CL_Inventario = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true, defaultValue: "xXxXx"),
                    CL_Cadeado = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CL_Tecnico = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false, defaultValue: "laboratorio"),
                    CL_Entrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CL_Saida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CL_Armario = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    CL_Observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Laboratorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Saida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registros_Equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tecnicos_Equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registros_EquipamentoId",
                table: "Registros",
                column: "EquipamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_EquipamentoId",
                table: "Tecnicos",
                column: "EquipamentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "TB_Laboratorio",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tecnicos");

            migrationBuilder.DropTable(
                name: "Equipamentos");
        }
    }
}