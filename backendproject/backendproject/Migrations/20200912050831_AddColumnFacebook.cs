using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class AddColumnFacebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pinterest",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Bios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vimeo",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "Pinterest",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Bios");

            migrationBuilder.DropColumn(
                name: "Vimeo",
                table: "Bios");
        }
    }
}
