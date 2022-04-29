using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClimbingGym.Data.Migrations
{
    public partial class ListOfUsersAddedToRoutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ApplicationUserRoute",
                columns: table => new
                {
                    RoutesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRoute", x => new { x.RoutesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRoute_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRoute_Routes_RoutesId",
                        column: x => x.RoutesId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRoute_UsersId",
                table: "ApplicationUserRoute",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserRoute");

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
    }
}
