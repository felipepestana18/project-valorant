using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace valorant_app_api.Migrations
{
    public partial class fixUid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uid",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uid",
                table: "Characters");
        }
    }
}
