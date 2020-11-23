using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class TableProductionAndTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Loriot",
                table: "Loriot");

            migrationBuilder.RenameTable(
                name: "Loriot",
                newName: "LoriotTest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoriotTest",
                table: "LoriotTest",
                column: "LoriotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LoriotTest",
                table: "LoriotTest");

            migrationBuilder.RenameTable(
                name: "LoriotTest",
                newName: "Loriot");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loriot",
                table: "Loriot",
                column: "LoriotId");
        }
    }
}
