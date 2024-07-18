using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace valorant_app_api.Migrations
{
    public partial class fixUuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uid",
                table: "Characters",
                newName: "uui");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uui",
                table: "Characters",
                newName: "uid");
        }
    }
}
