using Microsoft.EntityFrameworkCore.Migrations;

namespace Used_Books.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_Studente",
                table: "Book",
                newName: "Studente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Studente",
                table: "Book",
                newName: "id_Studente");
        }
    }
}
