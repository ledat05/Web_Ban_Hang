using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Ban_Hang.Migrations
{
    public partial class RenameIdToMaSP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "MaSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaSP",
                table: "Products",
                newName: "Id");
        }
    }
}
