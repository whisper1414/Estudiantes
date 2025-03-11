using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirtsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    IdEstudiante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuCrea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecCrea = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.IdEstudiante);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdInstructor = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuCrea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecCrea = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.IdMateria);
                });

            migrationBuilder.CreateTable(
                name: "EstudianteMateria",
                columns: table => new
                {
                    EstuditesNavigationIdEstudiante = table.Column<int>(type: "int", nullable: false),
                    MateriasNavigationIdMateria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstudianteMateria", x => new { x.EstuditesNavigationIdEstudiante, x.MateriasNavigationIdMateria });
                    table.ForeignKey(
                        name: "FK_EstudianteMateria_Estudiantes_EstuditesNavigationIdEstudiante",
                        column: x => x.EstuditesNavigationIdEstudiante,
                        principalTable: "Estudiantes",
                        principalColumn: "IdEstudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstudianteMateria_Materias_MateriasNavigationIdMateria",
                        column: x => x.MateriasNavigationIdMateria,
                        principalTable: "Materias",
                        principalColumn: "IdMateria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MateriasEstudiantes",
                columns: table => new
                {
                    IdEstudiante = table.Column<int>(type: "int", nullable: false),
                    IdMateria = table.Column<int>(type: "int", nullable: false),
                    UsuCrea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FecCrea = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriasEstudiantes", x => new { x.IdMateria, x.IdEstudiante });
                    table.ForeignKey(
                        name: "FK_MateriasEstudiantes_Estudiantes_IdEstudiante",
                        column: x => x.IdEstudiante,
                        principalTable: "Estudiantes",
                        principalColumn: "IdEstudiante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MateriasEstudiantes_Materias_IdMateria",
                        column: x => x.IdMateria,
                        principalTable: "Materias",
                        principalColumn: "IdMateria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudianteMateria_MateriasNavigationIdMateria",
                table: "EstudianteMateria",
                column: "MateriasNavigationIdMateria");

            migrationBuilder.CreateIndex(
                name: "IX_MateriasEstudiantes_IdEstudiante",
                table: "MateriasEstudiantes",
                column: "IdEstudiante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstudianteMateria");

            migrationBuilder.DropTable(
                name: "MateriasEstudiantes");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
