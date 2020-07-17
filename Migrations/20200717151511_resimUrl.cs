using Microsoft.EntityFrameworkCore.Migrations;

namespace SelenYapayZekaGit.Migrations
{
    public partial class resimUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Urun",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etkiket",
                table: "Etkiket");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Etkiket");

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Urun",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "ResimUrl",
                table: "Kategori",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EtiketId",
                table: "Etkiket",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urun",
                table: "Urun",
                column: "UrunId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etkiket",
                table: "Etkiket",
                column: "EtiketId");

            migrationBuilder.CreateTable(
                name: "UrunEtiket",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false),
                    EtkiketId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunEtiket", x => new { x.EtkiketId, x.UrunId });
                    table.ForeignKey(
                        name: "FK_UrunEtiket_Etkiket_EtkiketId",
                        column: x => x.EtkiketId,
                        principalTable: "Etkiket",
                        principalColumn: "EtiketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunEtiket_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UrunEtiket_UrunId",
                table: "UrunEtiket",
                column: "UrunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrunEtiket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urun",
                table: "Urun");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etkiket",
                table: "Etkiket");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Urun");

            migrationBuilder.DropColumn(
                name: "ResimUrl",
                table: "Kategori");

            migrationBuilder.DropColumn(
                name: "EtiketId",
                table: "Etkiket");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Urun",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Etkiket",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urun",
                table: "Urun",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etkiket",
                table: "Etkiket",
                column: "Id");
        }
    }
}
