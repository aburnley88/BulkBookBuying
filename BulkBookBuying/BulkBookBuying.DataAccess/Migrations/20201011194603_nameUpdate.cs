using Microsoft.EntityFrameworkCore.Migrations;

namespace BulkBookBuying.DataAccess.Migrations
{
    public partial class nameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAuthorized",
                table: "Companies");

            migrationBuilder.AddColumn<bool>(
                name: "IsAuthorizedCompany",
                table: "Companies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAuthorizedCompany",
                table: "Companies");

            migrationBuilder.AddColumn<bool>(
                name: "IsAuthorized",
                table: "Companies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
