using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SevenVorot.Migrations
{
    public partial class migration_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtherSpecificationsNamesJson",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OtherSpecificationsValuesJson",
                table: "products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherSpecificationsNamesJson",
                table: "products",
                type: "nvarchar(max)",
                maxLength: 20000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherSpecificationsValuesJson",
                table: "products",
                type: "nvarchar(max)",
                maxLength: 20000,
                nullable: true);
        }
    }
}
