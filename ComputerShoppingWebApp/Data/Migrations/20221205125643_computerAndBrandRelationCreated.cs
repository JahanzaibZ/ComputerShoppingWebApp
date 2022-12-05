using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShoppingWebApp.Data.Migrations
{
    public partial class computerAndBrandRelationCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "Computer",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Computer_BrandID",
                table: "Computer",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Computer_Brand_BrandID",
                table: "Computer",
                column: "BrandID",
                principalTable: "Brand",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Computer_Brand_BrandID",
                table: "Computer");

            migrationBuilder.DropIndex(
                name: "IX_Computer_BrandID",
                table: "Computer");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "Computer");
        }
    }
}
