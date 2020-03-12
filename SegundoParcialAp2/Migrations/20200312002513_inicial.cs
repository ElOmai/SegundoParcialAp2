using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcialAp2.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LlamadaDetalles",
                columns: table => new
                {
                    LlamadaDetalleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LlamadaId = table.Column<int>(nullable: false),
                    Problema = table.Column<string>(nullable: false),
                    Solucion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LlamadaDetalles", x => x.LlamadaDetalleId);
                });

            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    LlamadaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.LlamadaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LlamadaDetalles");

            migrationBuilder.DropTable(
                name: "Llamadas");
        }
    }
}
