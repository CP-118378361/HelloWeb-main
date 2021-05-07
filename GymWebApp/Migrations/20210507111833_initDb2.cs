using Microsoft.EntityFrameworkCore.Migrations;

namespace GymWebApp.Migrations
{
    public partial class initDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apparatuss",
                table: "Gymnasts",
                newName: "Apparatus");

            migrationBuilder.RenameColumn(
                name: "AgeSections",
                table: "Gymnasts",
                newName: "AgeSection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apparatus",
                table: "Gymnasts",
                newName: "Apparatuss");

            migrationBuilder.RenameColumn(
                name: "AgeSection",
                table: "Gymnasts",
                newName: "AgeSections");
        }
    }
}
