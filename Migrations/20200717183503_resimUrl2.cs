using Microsoft.EntityFrameworkCore.Migrations;

namespace SelenYapayZekaGit.Migrations
{
    public partial class resimUrl2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResimUrl",
                table: "Urun",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResimUrl",
                table: "Urun");
        }
    }
}
