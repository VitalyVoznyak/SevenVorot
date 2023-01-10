using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SevenVorot.Migrations
{
    public partial class migration_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecondPartition",
                table: "products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThridPartition",
                table: "products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecondPartition",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ThridPartition",
                table: "products");
        }
    }
}
