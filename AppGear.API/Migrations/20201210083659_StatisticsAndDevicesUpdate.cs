using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class StatisticsAndDevicesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoriotStatistics",
                columns: table => new
                {
                    LoriotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<string>(nullable: true),
                    DeviceEUI = table.Column<string>(nullable: true),
                    DailyCyclesCount = table.Column<int>(nullable: false),
                    CycleEventsCount = table.Column<int>(nullable: false),
                    DailyEventsCount = table.Column<int>(nullable: false),
                    CyclePeriod = table.Column<int>(nullable: false),
                    TimeStamp = table.Column<long>(nullable: false),
                    Date = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoriotStatistics", x => x.LoriotId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoriotStatistics");
        }
    }
}
