using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectoJaVi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Mensagem = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    JaViu = table.Column<string>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Finalizada = table.Column<bool>(type: "INTEGER", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: true),
                    Nota = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Serie");
        }
    }
}
