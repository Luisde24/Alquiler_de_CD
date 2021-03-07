using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Luisde_Prestamos_Cd.Migrations
{
    public partial class migracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alquiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noAlquiler = table.Column<int>(type: "int", nullable: false),
                    codigoCliente = table.Column<int>(type: "int", nullable: false),
                    fechaAlquiler = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valorAlquiler = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alquiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoTitulo = table.Column<int>(type: "int", nullable: false),
                    noCd = table.Column<int>(type: "int", nullable: false),
                    condicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoCliente = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nroDNI = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    temaInteres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "detalleAlquiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noAlquiler = table.Column<int>(type: "int", nullable: false),
                    item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codigoTitulo = table.Column<int>(type: "int", nullable: false),
                    noCd = table.Column<int>(type: "int", nullable: false),
                    diasPrestamo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleAlquiler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sancion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noSancion = table.Column<int>(type: "int", nullable: false),
                    codigoCliente = table.Column<int>(type: "int", nullable: false),
                    noAlquiler = table.Column<int>(type: "int", nullable: false),
                    tipoSancion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noDiasSancion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sancion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alquiler");

            migrationBuilder.DropTable(
                name: "cd");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "detalleAlquiler");

            migrationBuilder.DropTable(
                name: "sancion");
        }
    }
}
