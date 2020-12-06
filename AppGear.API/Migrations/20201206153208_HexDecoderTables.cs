using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class HexDecoderTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoriotDecoded",
                columns: table => new
                {
                    LoriotDecodedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DailyCyclesCount = table.Column<int>(nullable: false),
                    CycleEventsCount = table.Column<int>(nullable: false),
                    DailyEventsCount = table.Column<int>(nullable: false),
                    CyclePeriod = table.Column<short>(nullable: false),
                    TimeStamp = table.Column<long>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotDecoded", x => x.LoriotDecodedId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoriotDecoded");
        }
    }
}
