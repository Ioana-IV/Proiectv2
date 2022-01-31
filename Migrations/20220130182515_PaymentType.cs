using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ivanov_Ioana_Proiect.Migrations
{
    public partial class PaymentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Purchase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_PaymentTypeID",
                table: "Purchase",
                column: "PaymentTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_PaymentType_PaymentTypeID",
                table: "Purchase",
                column: "PaymentTypeID",
                principalTable: "PaymentType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_PaymentType_PaymentTypeID",
                table: "Purchase");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_PaymentTypeID",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Purchase");
        }
    }
}
