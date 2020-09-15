using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class AddColumnBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneHeader",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneHeader",
                table: "Bios");
        }
    }
}
