using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    IdentificacionP = table.Column<string>(nullable: false),
                    NombresP = table.Column<string>(nullable: true),
                    ApellidosP = table.Column<string>(nullable: true),
                    SexoP = table.Column<string>(nullable: true),
                    EdadP = table.Column<int>(nullable: false),
                    DepartamentoP = table.Column<string>(nullable: true),
                    CiudadP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdentificacionP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
