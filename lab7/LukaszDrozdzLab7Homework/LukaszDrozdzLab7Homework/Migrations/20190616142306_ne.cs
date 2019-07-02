using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LukaszDrozdzLab7Homework.Migrations
{
    public partial class ne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CruiserID",
                table: "Missions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestroyerID",
                table: "Missions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DestroyerRepair",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ShipID = table.Column<int>(nullable: false),
                    DestroyerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestroyerRepair", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DestroyerRepair_Destroyers_DestroyerID",
                        column: x => x.DestroyerID,
                        principalTable: "Destroyers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DestroyerRepair_Cruisers_ShipID",
                        column: x => x.ShipID,
                        principalTable: "Cruisers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CruiserID",
                table: "Missions",
                column: "CruiserID");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_DestroyerID",
                table: "Missions",
                column: "DestroyerID");

            migrationBuilder.CreateIndex(
                name: "IX_DestroyerRepair_DestroyerID",
                table: "DestroyerRepair",
                column: "DestroyerID");

            migrationBuilder.CreateIndex(
                name: "IX_DestroyerRepair_ShipID",
                table: "DestroyerRepair",
                column: "ShipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Cruisers_CruiserID",
                table: "Missions",
                column: "CruiserID",
                principalTable: "Cruisers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Destroyers_DestroyerID",
                table: "Missions",
                column: "DestroyerID",
                principalTable: "Destroyers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Cruisers_CruiserID",
                table: "Missions");

            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Destroyers_DestroyerID",
                table: "Missions");

            migrationBuilder.DropTable(
                name: "DestroyerRepair");

            migrationBuilder.DropIndex(
                name: "IX_Missions_CruiserID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_DestroyerID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "CruiserID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "DestroyerID",
                table: "Missions");
        }
    }
}
