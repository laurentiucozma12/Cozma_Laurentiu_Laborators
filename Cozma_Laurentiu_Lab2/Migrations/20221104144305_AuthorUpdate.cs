using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cozma_Laurentiu_Lab2.Migrations
{
    public partial class AuthorUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Author",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "Id");
        }
    }
}
