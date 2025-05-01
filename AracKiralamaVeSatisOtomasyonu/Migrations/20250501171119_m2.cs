using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AracKiralamaVeSatisOtomasyonu.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_Kategori_KategoriId1",
                table: "Arac");

            migrationBuilder.DropIndex(
                name: "IX_Arac_KategoriId1",
                table: "Arac");

            migrationBuilder.DropColumn(
                name: "KategoriId1",
                table: "Arac");

            migrationBuilder.AlterColumn<int>(
                name: "KategoriId",
                table: "Arac",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Arac_KategoriId",
                table: "Arac",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_Kategori_KategoriId",
                table: "Arac",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arac_Kategori_KategoriId",
                table: "Arac");

            migrationBuilder.DropIndex(
                name: "IX_Arac_KategoriId",
                table: "Arac");

            migrationBuilder.AlterColumn<string>(
                name: "KategoriId",
                table: "Arac",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId1",
                table: "Arac",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Arac_KategoriId1",
                table: "Arac",
                column: "KategoriId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Arac_Kategori_KategoriId1",
                table: "Arac",
                column: "KategoriId1",
                principalTable: "Kategori",
                principalColumn: "KategoriId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
