using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SevenVorot.Migrations
{
    public partial class migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "otherSpecificationsNamesJson",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "otherSpecificationsValuesJson",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "otherSpecificationsNamesJson",
                table: "products");

            migrationBuilder.DropColumn(
                name: "otherSpecificationsValuesJson",
                table: "products");
        }
    }
}
