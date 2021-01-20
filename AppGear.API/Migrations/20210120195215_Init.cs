using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoriotDecoded",
                columns: table => new
                {
                    LoriotDecodedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EUI = table.Column<string>(nullable: true),
                    DailyCyclesCount = table.Column<int>(nullable: false),
                    CycleEventsCount = table.Column<int>(nullable: false),
                    DailyEventsCount = table.Column<int>(nullable: false),
                    CyclePeriod = table.Column<short>(nullable: false),
                    TimeStamp = table.Column<long>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    Procenat = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotDecoded", x => x.LoriotDecodedId);
                });

            migrationBuilder.CreateTable(
                name: "LoriotDevices",
                columns: table => new
                {
                    DEV_ID = table.Column<string>(nullable: false),
                    PCB_ID = table.Column<string>(nullable: true),
                    DEV_EUI = table.Column<string>(nullable: true),
                    APP_EUI = table.Column<string>(nullable: true),
                    APP_KEY = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotDevices", x => x.DEV_ID);
                });

            migrationBuilder.CreateTable(
                name: "LoriotProduction",
                columns: table => new
                {
                    LoriotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cmd = table.Column<string>(nullable: true),
                    EUI = table.Column<string>(nullable: true),
                    ts = table.Column<long>(nullable: false),
                    ack = table.Column<bool>(nullable: false),
                    bat = table.Column<int>(nullable: false),
                    fcnt = table.Column<int>(nullable: false),
                    port = table.Column<int>(nullable: false),
                    encdata = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotProduction", x => x.LoriotId);
                });

            migrationBuilder.CreateTable(
                name: "LoriotTest",
                columns: table => new
                {
                    LoriotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cmd = table.Column<string>(nullable: true),
                    EUI = table.Column<string>(nullable: true),
                    ts = table.Column<long>(nullable: false),
                    ack = table.Column<bool>(nullable: false),
                    bat = table.Column<int>(nullable: false),
                    fcnt = table.Column<int>(nullable: false),
                    port = table.Column<int>(nullable: false),
                    encdata = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotTest", x => x.LoriotId);
                });

            migrationBuilder.InsertData(
                table: "LoriotDevices",
                columns: new[] { "DEV_ID", "APP_EUI", "APP_KEY", "DEV_EUI", "PCB_ID" },
                values: new object[,]
                {
                    { "MMD1001001991", "050600000000FFFF", "0004A30B0007D5C588A783A1A7A0E3A1", "0004A30B0007D5C5", "MMP1601003746" },
                    { "MMD1001001992", "050600000000FFFF", "0004A30B0007932B88A783A1A7A0E3A1", "0004A30B0007932B", "MMP1601003747" },
                    { "MMD1001001993", "050600000000FFFF", "0004A30B0007C3BE88A783A1A7A0E3A1", "0004A30B0007C3BE", "MMP1601003748" },
                    { "MMD1001001994", "050600000000FFFF", "0004A30B0007FE0788A783A1A7A0E3A1", "0004A30B0007FE07", "MMP1601003749" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoriotDecoded");

            migrationBuilder.DropTable(
                name: "LoriotDevices");

            migrationBuilder.DropTable(
                name: "LoriotProduction");

            migrationBuilder.DropTable(
                name: "LoriotTest");
        }
    }
}
