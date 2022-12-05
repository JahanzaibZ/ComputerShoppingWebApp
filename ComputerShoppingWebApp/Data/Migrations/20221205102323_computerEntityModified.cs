using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShoppingWebApp.Data.Migrations
{
    public partial class computerEntityModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Specifications",
                table: "Computer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not specified");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specifications",
                table: "Computer");
        }
    }
}
