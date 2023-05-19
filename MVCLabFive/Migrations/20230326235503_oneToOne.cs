using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabFive.Migrations
{
    public partial class oneToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Priceoffers_Books_BookId",
                table: "Priceoffers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Priceoffers_Books_BookId",
                table: "Priceoffers");

            migrationBuilder.DropIndex(
                name: "IX_Priceoffers_BookId",
                table: "Priceoffers");
        }
    }
}
