using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClimbingGym.Data.Migrations
{
    public partial class ListOfRoutesAddedToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Routes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_ApplicationUserId",
                table: "Routes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_AspNetUsers_ApplicationUserId",
                table: "Routes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_AspNetUsers_ApplicationUserId",
                table: "Routes");

            migrationBuilder.DropIndex(
                name: "IX_Routes_ApplicationUserId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Routes");
        }
    }
}
