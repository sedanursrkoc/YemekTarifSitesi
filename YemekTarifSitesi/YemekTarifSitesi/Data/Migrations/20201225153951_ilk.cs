using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekTarifSitesi.Data.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Malzeme",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(nullable: true),
                    Miktar = table.Column<double>(nullable: false),
                    MiktarTur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malzeme", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tur",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Yorum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yemek",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdi = table.Column<string>(nullable: true),
                    Malzemeler = table.Column<string>(nullable: true),
                    Tarif = table.Column<string>(nullable: true),
                    Yorum = table.Column<string>(nullable: true),
                    Puan = table.Column<double>(nullable: true),
                    Fotograf = table.Column<string>(nullable: true),
                    TurID = table.Column<string>(nullable: true),
                    TurID1 = table.Column<int>(nullable: true),
                    YorumID = table.Column<string>(nullable: true),
                    YorumlarID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemek", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yemek_Tur_TurID1",
                        column: x => x.TurID1,
                        principalTable: "Tur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Yemek_Yorumlar_YorumlarID",
                        column: x => x.YorumlarID,
                        principalTable: "Yorumlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_TurID1",
                table: "Yemek",
                column: "TurID1");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_YorumlarID",
                table: "Yemek",
                column: "YorumlarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Malzeme");

            migrationBuilder.DropTable(
                name: "Yemek");

            migrationBuilder.DropTable(
                name: "Tur");

            migrationBuilder.DropTable(
                name: "Yorumlar");
        }
    }
}
