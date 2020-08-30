using Microsoft.EntityFrameworkCore.Migrations;

namespace Novi.Migrations
{
    public partial class OrderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "HireFrom", "HireTill" },
                values: new object[] { "Olla", "Arrivaderci" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "HireFrom", "HireTill" },
                values: new object[] { "Hallo", "Dag" });
        }
    }
}
