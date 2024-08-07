using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace valorant_app_api.Migrations
{
    public partial class fixParams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Maps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BodyImgURL",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThumbImgURL",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Maps");

            migrationBuilder.DropColumn(
                name: "BodyImgURL",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ThumbImgURL",
                table: "Characters");
        }
    }
}
