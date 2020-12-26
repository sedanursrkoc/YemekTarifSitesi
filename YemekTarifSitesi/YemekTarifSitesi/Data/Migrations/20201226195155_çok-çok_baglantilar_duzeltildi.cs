using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekTarifSitesi.Data.Migrations
{
    public partial class çokçok_baglantilar_duzeltildi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YemekMalzeme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekId = table.Column<int>(nullable: false),
                    MalzemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekMalzeme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekMalzeme_Malzeme_MalzemeId",
                        column: x => x.MalzemeId,
                        principalTable: "Malzeme",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekMalzeme_Yemek_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekTur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekId = table.Column<int>(nullable: false),
                    TurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekTur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekTur_Tur_TurId",
                        column: x => x.TurId,
                        principalTable: "Tur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekTur_Yemek_YemekId",
                        column: x => x.YemekId,
                        principalTable: "Yemek",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YemekMalzeme_MalzemeId",
                table: "YemekMalzeme",
                column: "MalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekMalzeme_YemekId",
                table: "YemekMalzeme",
                column: "YemekId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekTur_TurId",
                table: "YemekTur",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekTur_YemekId",
                table: "YemekTur",
                column: "YemekId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YemekMalzeme");

            migrationBuilder.DropTable(
                name: "YemekTur");
        }
    }
}
