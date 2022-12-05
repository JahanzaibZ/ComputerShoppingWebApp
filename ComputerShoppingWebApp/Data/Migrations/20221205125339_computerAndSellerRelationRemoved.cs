using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShoppingWebApp.Data.Migrations
{
    public partial class computerAndSellerRelationRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Seller_SellerID",
                table: "Computer");

            migrationBuilder.DropIndex(
                name: "IX_Computer_SellerID",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "SellerID",
                table: "Computer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Computer_SellerID",
                table: "Computer",
                column: "SellerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Seller_SellerID",
                table: "Computer",
                column: "SellerID",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
