using Microsoft.EntityFrameworkCore.Migrations;

namespace GarageOrganizer.EntityFramework.Migrations
{
    public partial class addedrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ClientId",
                table: "Cars",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Clients_ClientId",
                table: "Cars",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Clients_ClientId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ClientId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Cars");
        }
    }
}
