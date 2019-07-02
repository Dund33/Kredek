using Microsoft.EntityFrameworkCore.Migrations;

namespace LukaszDrozdzLab7Homework.Migrations
{
    public partial class curren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Repairs_ShipID",
                table: "Repairs",
                column: "ShipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Cruisers_ShipID",
                table: "Repairs",
                column: "ShipID",
                principalTable: "Cruisers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Cruisers_ShipID",
                table: "Repairs");

            migrationBuilder.DropIndex(
                name: "IX_Repairs_ShipID",
                table: "Repairs");
        }
    }
}
