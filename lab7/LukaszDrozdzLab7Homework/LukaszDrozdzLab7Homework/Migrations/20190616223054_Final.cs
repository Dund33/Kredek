using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LukaszDrozdzLab7Homework.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestroyerRepair_Destroyers_DestroyerID",
                table: "DestroyerRepair");

            migrationBuilder.DropForeignKey(
                name: "FK_DestroyerRepair_Cruisers_ShipID",
                table: "DestroyerRepair");

            migrationBuilder.DropIndex(
                name: "IX_DestroyerRepair_DestroyerID",
                table: "DestroyerRepair");

            migrationBuilder.DropColumn(
                name: "DestroyerID",
                table: "DestroyerRepair");

            migrationBuilder.CreateTable(
                name: "GetRepairDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ShipID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetRepairDTO", x => x.ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DestroyerRepair_Destroyers_ShipID",
                table: "DestroyerRepair",
                column: "ShipID",
                principalTable: "Destroyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DestroyerRepair_Destroyers_ShipID",
                table: "DestroyerRepair");

            migrationBuilder.DropTable(
                name: "GetRepairDTO");

            migrationBuilder.AddColumn<int>(
                name: "DestroyerID",
                table: "DestroyerRepair",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DestroyerRepair_DestroyerID",
                table: "DestroyerRepair",
                column: "DestroyerID");

            migrationBuilder.AddForeignKey(
                name: "FK_DestroyerRepair_Destroyers_DestroyerID",
                table: "DestroyerRepair",
                column: "DestroyerID",
                principalTable: "Destroyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DestroyerRepair_Cruisers_ShipID",
                table: "DestroyerRepair",
                column: "ShipID",
                principalTable: "Cruisers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
