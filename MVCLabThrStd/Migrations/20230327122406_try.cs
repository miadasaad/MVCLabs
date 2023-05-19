using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCLabThrStd.Migrations
{
    public partial class @try : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptNo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptNo",
                table: "Students",
                column: "DeptNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptNo",
                table: "Students",
                column: "DeptNo",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptNo",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptNo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeptNo",
                table: "Students");
        }
    }
}
