using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class TimeStampCorrectionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ts",
                table: "Loriot",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ts",
                table: "Loriot",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
