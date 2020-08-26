using Microsoft.EntityFrameworkCore.Migrations;

namespace Novi.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Abstract art", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Surrealistic art", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Other art", null });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "CategoryId", "Description", "Hireable", "ImageThumbnailUrl", "ImageUrl", "IsArticleOfTheMonth", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Our famous apple arts!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/appleartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/appleart.jpg", true, "Apple Article", 12.95m },
                    { 4, 1, "A summer classic!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryart.jpg", false, "Cherry Article", 15.95m },
                    { 7, 1, "Sweet as peach", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachart.jpg", false, "Peach Article", 15.95m },
                    { 9, 1, "My God, so sweet!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbart.jpg", true, "Rhubarb Article", 15.95m },
                    { 10, 1, "Our delicious strawberry art!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryart.jpg", false, "Strawberry Article", 15.95m },
                    { 2, 2, "You'll love it!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", false, "Blueberry Cheese Cake", 18.95m },
                    { 3, 2, "Plain cheese cake. Plain pleasure.", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", false, "Cheese Cake", 18.95m },
                    { 11, 2, "You'll love it!", false, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, "Strawberry Cheese Cake", 18.95m },
                    { 5, 3, "Happy holidays with this art!", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleart.jpg", false, "Christmas Apple Article", 13.95m },
                    { 6, 3, "A Christmas favorite", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryart.jpg", false, "Cranberry Article", 17.95m },
                    { 8, 3, "Our Halloween favorite", true, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinartsmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinart.jpg", true, "Pumpkin Article", 12.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
