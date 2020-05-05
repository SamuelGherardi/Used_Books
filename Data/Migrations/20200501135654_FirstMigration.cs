using Microsoft.EntityFrameworkCore.Migrations;

namespace Used_Books.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Editore = table.Column<string>(nullable: true),
                    Corso_studio = table.Column<string>(nullable: true),
                    Classe = table.Column<string>(nullable: true),
                    Materia = table.Column<string>(nullable: true),
                    id_Studente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
