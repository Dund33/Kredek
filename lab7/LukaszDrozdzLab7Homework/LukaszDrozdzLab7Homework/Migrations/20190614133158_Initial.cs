using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LukaszDrozdzLab7Homework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cruisers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    PlasmaGuns = table.Column<int>(nullable: false),
                    HasStarDrive = table.Column<bool>(nullable: false),
                    TWR = table.Column<float>(nullable: false),
                    Isp = table.Column<float>(nullable: false),
                    Thrust = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruisers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Destroyers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    BeamTrackers = table.Column<int>(nullable: false),
                    TWR = table.Column<float>(nullable: false),
                    Isp = table.Column<float>(nullable: false),
                    Thrust = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destroyers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GetBasicCruiserDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    PlasmaGuns = table.Column<int>(nullable: false),
                    HasStarDrive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetBasicCruiserDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GetBasicDestroyerDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    BeamTrackers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetBasicDestroyerDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GetFullCruiserDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    PlasmaGuns = table.Column<int>(nullable: false),
                    HasStarDrive = table.Column<bool>(nullable: false),
                    TWR = table.Column<float>(nullable: false),
                    Isp = table.Column<float>(nullable: false),
                    Thrust = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetFullCruiserDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GetFullDestroyerDTO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lasers = table.Column<int>(nullable: false),
                    BeamTrackers = table.Column<int>(nullable: false),
                    TWR = table.Column<float>(nullable: false),
                    Isp = table.Column<float>(nullable: false),
                    Thrust = table.Column<float>(nullable: false),
                    Weight = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetFullDestroyerDTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShipID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Repairs",
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
                    table.PrimaryKey("PK_Repairs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cruisers");

            migrationBuilder.DropTable(
                name: "Destroyers");

            migrationBuilder.DropTable(
                name: "GetBasicCruiserDTO");

            migrationBuilder.DropTable(
                name: "GetBasicDestroyerDTO");

            migrationBuilder.DropTable(
                name: "GetFullCruiserDTO");

            migrationBuilder.DropTable(
                name: "GetFullDestroyerDTO");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Repairs");
        }
    }
}
