using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ivanov_Ioana_Proiect.Migrations
{
    public partial class OtherDBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payee", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CategoryID",
                table: "Purchase",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_PayeeID",
                table: "Purchase",
                column: "PayeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Category_CategoryID",
                table: "Purchase",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Payee_PayeeID",
                table: "Purchase",
                column: "PayeeID",
                principalTable: "Payee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Category_CategoryID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Payee_PayeeID",
                table: "Purchase");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Payee");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CategoryID",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_PayeeID",
                table: "Purchase");
        }
    }
}
