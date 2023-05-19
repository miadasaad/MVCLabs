using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabFive.Migrations
{
    public partial class offer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Priceoffers_OfferId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_OfferId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Books_OfferId",
                table: "Books",
                column: "OfferId",
                unique: true,
                filter: "[OfferId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Priceoffers_OfferId",
                table: "Books",
                column: "OfferId",
                principalTable: "Priceoffers",
                principalColumn: "priceofferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Priceoffers_OfferId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_OfferId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "OfferId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_OfferId",
                table: "Books",
                column: "OfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Priceoffers_OfferId",
                table: "Books",
                column: "OfferId",
                principalTable: "Priceoffers",
                principalColumn: "priceofferId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
