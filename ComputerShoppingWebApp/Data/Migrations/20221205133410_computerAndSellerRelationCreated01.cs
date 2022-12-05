using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShoppingWebApp.Data.Migrations
{
    public partial class computerAndSellerRelationCreated01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerSeller",
                columns: table => new
                {
                    ComputersID = table.Column<int>(type: "int", nullable: false),
                    SellersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSeller", x => new { x.ComputersID, x.SellersId });
                    table.ForeignKey(
                        name: "FK_ComputerSeller_Computer_ComputersID",
                        column: x => x.ComputersID,
                        principalTable: "Computer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerSeller_Seller_SellersId",
                        column: x => x.SellersId,
                        principalTable: "Seller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerSeller_SellersId",
                table: "ComputerSeller",
                column: "SellersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComputerSeller");
        }
    }
}
