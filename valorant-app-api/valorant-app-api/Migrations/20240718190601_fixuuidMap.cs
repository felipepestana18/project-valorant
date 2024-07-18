using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace valorant_app_api.Migrations
{
    public partial class fixuuidMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uuid",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uuid",
                table: "Maps");
        }
    }
}
