using Microsoft.EntityFrameworkCore.Migrations;

namespace GymWebApp.Migrations
{
    public partial class initdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Judges");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Judges",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
