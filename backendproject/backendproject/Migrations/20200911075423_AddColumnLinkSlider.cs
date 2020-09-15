using Microsoft.EntityFrameworkCore.Migrations;

namespace backendproject.Migrations
{
    public partial class AddColumnLinkSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Sliders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Sliders");
        }
    }
}
