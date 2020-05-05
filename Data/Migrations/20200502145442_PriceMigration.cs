using Microsoft.EntityFrameworkCore.Migrations;

namespace Used_Books.Data.Migrations
{
    public partial class PriceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Prezzo",
                table: "Book",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prezzo",
                table: "Book");
        }
    }
}
