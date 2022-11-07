using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "Price", "PriceUrl", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 1, "brand1", "description1", "name1", 10L, "url1", 5, "type1" },
                    { 2, "brand2", "description2", "name2", 12L, "url2", 2, "type2" },
                    { 3, "brand3", "description3", "name3", 13L, "url3", 3, "type3" },
                    { 4, "brand4", "description4", "name4", 14L, "url4", 4, "type4" },
                    { 5, "brand5", "description5", "name5", 15L, "url5", 5, "type5" },
                    { 6, "brand6", "description6", "name6", 16L, "url6", 6, "type6" },
                    { 7, "brand7", "description7", "name7", 17L, "url7", 7, "type7" },
                    { 8, "brand8", "description8", "name8", 18L, "url8", 8, "type8" },
                    { 9, "brand9", "description9", "name9", 19L, "url9", 9, "type9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
