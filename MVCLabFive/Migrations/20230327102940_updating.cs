using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabFive.Migrations
{
    public partial class updating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers");

            migrationBuilder.AddColumn<int>(
                name: "OfferId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers",
                column: "BookId");

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Priceoffers_OfferId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers");

            migrationBuilder.DropIndex(
                name: "IX_Books_OfferId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "OfferId",
                table: "Books");

            migrationBuilder.CreateIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers",
                column: "BookId",
                unique: true);
        }
    }
}
