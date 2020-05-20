using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apoyos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Persona = table.Column<string>(nullable: true),
                    ModalidadApoyo = table.Column<string>(nullable: true),
                    ValorApoyo = table.Column<int>(nullable: false),
                    FechaEntrega = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apoyos", x => x.Id);
                });

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
                    CiudadP = table.Column<string>(nullable: true),
                    ValorAcumuladoApoyo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.IdentificacionP);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apoyos");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}
