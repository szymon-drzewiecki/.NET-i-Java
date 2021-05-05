using Microsoft.EntityFrameworkCore.Migrations;

namespace KursyWalut.Migrations
{
    public partial class @base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dane",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timestamp = table.Column<int>(type: "int", nullable: false),
                    PLN = table.Column<float>(type: "real", nullable: false),
                    EUR = table.Column<float>(type: "real", nullable: false),
                    BTC = table.Column<float>(type: "real", nullable: false),
                    COP = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dane", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dane");
        }
    }
}
