using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekTarifSitesi.Data.Migrations
{
    public partial class guncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yemek_Tur_TurID1",
                table: "Yemek");

            migrationBuilder.DropForeignKey(
                name: "FK_Yemek_Yorumlar_YorumlarID",
                table: "Yemek");

            migrationBuilder.DropIndex(
                name: "IX_Yemek_TurID1",
                table: "Yemek");

            migrationBuilder.DropIndex(
                name: "IX_Yemek_YorumlarID",
                table: "Yemek");

            migrationBuilder.DropColumn(
                name: "TurID",
                table: "Yemek");

            migrationBuilder.DropColumn(
                name: "TurID1",
                table: "Yemek");

            migrationBuilder.DropColumn(
                name: "Yorum",
                table: "Yemek");

            migrationBuilder.DropColumn(
                name: "YorumID",
                table: "Yemek");

            migrationBuilder.DropColumn(
                name: "YorumlarID",
                table: "Yemek");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Yorumlar",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Yemek",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tur",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Malzeme",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "YemekId",
                table: "Yorumlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_YemekId",
                table: "Yorumlar",
                column: "YemekId");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlar_Yemek_YemekId",
                table: "Yorumlar",
                column: "YemekId",
                principalTable: "Yemek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlar_Yemek_YemekId",
                table: "Yorumlar");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlar_YemekId",
                table: "Yorumlar");

            migrationBuilder.DropColumn(
                name: "YemekId",
                table: "Yorumlar");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Yorumlar",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Yemek",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tur",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Malzeme",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "TurID",
                table: "Yemek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurID1",
                table: "Yemek",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yorum",
                table: "Yemek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YorumID",
                table: "Yemek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YorumlarID",
                table: "Yemek",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_TurID1",
                table: "Yemek",
                column: "TurID1");

            migrationBuilder.CreateIndex(
                name: "IX_Yemek_YorumlarID",
                table: "Yemek",
                column: "YorumlarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yemek_Tur_TurID1",
                table: "Yemek",
                column: "TurID1",
                principalTable: "Tur",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Yemek_Yorumlar_YorumlarID",
                table: "Yemek",
                column: "YorumlarID",
                principalTable: "Yorumlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
