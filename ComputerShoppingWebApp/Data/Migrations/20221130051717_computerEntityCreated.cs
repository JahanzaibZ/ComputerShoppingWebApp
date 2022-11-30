using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShoppingWebApp.Data.Migrations
{
    public partial class computerEntityCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "url",
                table: "Computer",
                newName: "URL");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Computer",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Computer",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "brand",
                table: "Computer",
                newName: "Brand");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Computer",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Computer");

            migrationBuilder.RenameColumn(
                name: "URL",
                table: "Computer",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Computer",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Computer",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "Brand",
                table: "Computer",
                newName: "brand");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Computer",
                newName: "id");
        }
    }
}
