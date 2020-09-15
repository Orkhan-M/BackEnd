using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class ChangeTableBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoHeaderHome",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoHeaderHome",
                table: "Bios");
        }
    }
}
