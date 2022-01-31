using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ivanov_Ioana_Proiect.Migrations
{
    public partial class DetailsOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Purchase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }
    }
}
