using Microsoft.EntityFrameworkCore.Migrations;

namespace AppGear.API.Migrations
{
    public partial class TestAndProductionTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoriotProduction");
        }
    }
}
