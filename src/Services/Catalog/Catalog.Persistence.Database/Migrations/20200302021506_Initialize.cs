using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 781m },
                    { 73, "Description for product 73", "Product 73", 222m },
                    { 72, "Description for product 72", "Product 72", 834m },
                    { 71, "Description for product 71", "Product 71", 384m },
                    { 70, "Description for product 70", "Product 70", 152m },
                    { 69, "Description for product 69", "Product 69", 694m },
                    { 68, "Description for product 68", "Product 68", 246m },
                    { 67, "Description for product 67", "Product 67", 576m },
                    { 66, "Description for product 66", "Product 66", 253m },
                    { 65, "Description for product 65", "Product 65", 362m },
                    { 64, "Description for product 64", "Product 64", 906m },
                    { 63, "Description for product 63", "Product 63", 461m },
                    { 62, "Description for product 62", "Product 62", 348m },
                    { 61, "Description for product 61", "Product 61", 368m },
                    { 60, "Description for product 60", "Product 60", 630m },
                    { 59, "Description for product 59", "Product 59", 361m },
                    { 58, "Description for product 58", "Product 58", 642m },
                    { 57, "Description for product 57", "Product 57", 206m },
                    { 56, "Description for product 56", "Product 56", 778m },
                    { 55, "Description for product 55", "Product 55", 471m },
                    { 54, "Description for product 54", "Product 54", 876m },
                    { 53, "Description for product 53", "Product 53", 791m },
                    { 74, "Description for product 74", "Product 74", 591m },
                    { 52, "Description for product 52", "Product 52", 223m },
                    { 75, "Description for product 75", "Product 75", 399m },
                    { 77, "Description for product 77", "Product 77", 431m },
                    { 98, "Description for product 98", "Product 98", 765m },
                    { 97, "Description for product 97", "Product 97", 151m },
                    { 96, "Description for product 96", "Product 96", 537m },
                    { 95, "Description for product 95", "Product 95", 853m },
                    { 94, "Description for product 94", "Product 94", 125m },
                    { 93, "Description for product 93", "Product 93", 130m },
                    { 92, "Description for product 92", "Product 92", 938m },
                    { 91, "Description for product 91", "Product 91", 605m },
                    { 90, "Description for product 90", "Product 90", 446m },
                    { 89, "Description for product 89", "Product 89", 728m },
                    { 88, "Description for product 88", "Product 88", 670m },
                    { 87, "Description for product 87", "Product 87", 658m },
                    { 86, "Description for product 86", "Product 86", 641m },
                    { 85, "Description for product 85", "Product 85", 761m },
                    { 84, "Description for product 84", "Product 84", 584m },
                    { 83, "Description for product 83", "Product 83", 273m },
                    { 82, "Description for product 82", "Product 82", 150m },
                    { 81, "Description for product 81", "Product 81", 565m },
                    { 80, "Description for product 80", "Product 80", 449m },
                    { 79, "Description for product 79", "Product 79", 714m },
                    { 78, "Description for product 78", "Product 78", 877m },
                    { 76, "Description for product 76", "Product 76", 284m },
                    { 51, "Description for product 51", "Product 51", 799m },
                    { 50, "Description for product 50", "Product 50", 518m },
                    { 49, "Description for product 49", "Product 49", 745m },
                    { 22, "Description for product 22", "Product 22", 103m },
                    { 21, "Description for product 21", "Product 21", 697m },
                    { 20, "Description for product 20", "Product 20", 186m },
                    { 19, "Description for product 19", "Product 19", 714m },
                    { 18, "Description for product 18", "Product 18", 777m },
                    { 17, "Description for product 17", "Product 17", 226m },
                    { 16, "Description for product 16", "Product 16", 865m },
                    { 15, "Description for product 15", "Product 15", 764m },
                    { 14, "Description for product 14", "Product 14", 819m },
                    { 13, "Description for product 13", "Product 13", 345m },
                    { 12, "Description for product 12", "Product 12", 122m },
                    { 11, "Description for product 11", "Product 11", 602m },
                    { 10, "Description for product 10", "Product 10", 126m },
                    { 9, "Description for product 9", "Product 9", 467m },
                    { 8, "Description for product 8", "Product 8", 464m },
                    { 7, "Description for product 7", "Product 7", 267m },
                    { 6, "Description for product 6", "Product 6", 707m },
                    { 5, "Description for product 5", "Product 5", 596m },
                    { 4, "Description for product 4", "Product 4", 491m },
                    { 3, "Description for product 3", "Product 3", 923m },
                    { 2, "Description for product 2", "Product 2", 693m },
                    { 23, "Description for product 23", "Product 23", 587m },
                    { 24, "Description for product 24", "Product 24", 380m },
                    { 25, "Description for product 25", "Product 25", 230m },
                    { 26, "Description for product 26", "Product 26", 966m },
                    { 48, "Description for product 48", "Product 48", 388m },
                    { 47, "Description for product 47", "Product 47", 501m },
                    { 46, "Description for product 46", "Product 46", 781m },
                    { 45, "Description for product 45", "Product 45", 666m },
                    { 44, "Description for product 44", "Product 44", 709m },
                    { 43, "Description for product 43", "Product 43", 671m },
                    { 42, "Description for product 42", "Product 42", 512m },
                    { 41, "Description for product 41", "Product 41", 786m },
                    { 40, "Description for product 40", "Product 40", 222m },
                    { 39, "Description for product 39", "Product 39", 655m },
                    { 99, "Description for product 99", "Product 99", 447m },
                    { 38, "Description for product 38", "Product 38", 392m },
                    { 36, "Description for product 36", "Product 36", 712m },
                    { 35, "Description for product 35", "Product 35", 224m },
                    { 34, "Description for product 34", "Product 34", 199m },
                    { 33, "Description for product 33", "Product 33", 546m },
                    { 32, "Description for product 32", "Product 32", 449m },
                    { 31, "Description for product 31", "Product 31", 764m },
                    { 30, "Description for product 30", "Product 30", 561m },
                    { 29, "Description for product 29", "Product 29", 102m },
                    { 28, "Description for product 28", "Product 28", 918m },
                    { 27, "Description for product 27", "Product 27", 438m },
                    { 37, "Description for product 37", "Product 37", 580m },
                    { 100, "Description for product 100", "Product 100", 513m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 16 },
                    { 73, 73, 16 },
                    { 72, 72, 5 },
                    { 71, 71, 0 },
                    { 70, 70, 0 },
                    { 69, 69, 16 },
                    { 68, 68, 12 },
                    { 67, 67, 9 },
                    { 66, 66, 16 },
                    { 65, 65, 3 },
                    { 64, 64, 18 },
                    { 63, 63, 13 },
                    { 62, 62, 17 },
                    { 61, 61, 0 },
                    { 60, 60, 5 },
                    { 59, 59, 0 },
                    { 58, 58, 3 },
                    { 57, 57, 11 },
                    { 56, 56, 6 },
                    { 55, 55, 3 },
                    { 54, 54, 0 },
                    { 53, 53, 7 },
                    { 74, 74, 2 },
                    { 52, 52, 8 },
                    { 75, 75, 4 },
                    { 77, 77, 5 },
                    { 98, 98, 6 },
                    { 97, 97, 5 },
                    { 96, 96, 12 },
                    { 95, 95, 5 },
                    { 94, 94, 14 },
                    { 93, 93, 13 },
                    { 92, 92, 18 },
                    { 91, 91, 14 },
                    { 90, 90, 4 },
                    { 89, 89, 13 },
                    { 88, 88, 2 },
                    { 87, 87, 1 },
                    { 86, 86, 9 },
                    { 85, 85, 12 },
                    { 84, 84, 5 },
                    { 83, 83, 8 },
                    { 82, 82, 15 },
                    { 81, 81, 1 },
                    { 80, 80, 11 },
                    { 79, 79, 17 },
                    { 78, 78, 4 },
                    { 76, 76, 10 },
                    { 51, 51, 1 },
                    { 50, 50, 0 },
                    { 49, 49, 8 },
                    { 22, 22, 9 },
                    { 21, 21, 9 },
                    { 20, 20, 15 },
                    { 19, 19, 9 },
                    { 18, 18, 16 },
                    { 17, 17, 19 },
                    { 16, 16, 3 },
                    { 15, 15, 7 },
                    { 14, 14, 8 },
                    { 13, 13, 9 },
                    { 12, 12, 12 },
                    { 11, 11, 5 },
                    { 10, 10, 1 },
                    { 9, 9, 11 },
                    { 8, 8, 19 },
                    { 7, 7, 14 },
                    { 6, 6, 15 },
                    { 5, 5, 4 },
                    { 4, 4, 12 },
                    { 3, 3, 12 },
                    { 2, 2, 8 },
                    { 23, 23, 16 },
                    { 24, 24, 8 },
                    { 25, 25, 11 },
                    { 26, 26, 19 },
                    { 48, 48, 19 },
                    { 47, 47, 17 },
                    { 46, 46, 19 },
                    { 45, 45, 10 },
                    { 44, 44, 11 },
                    { 43, 43, 4 },
                    { 42, 42, 18 },
                    { 41, 41, 10 },
                    { 40, 40, 6 },
                    { 39, 39, 19 },
                    { 99, 99, 8 },
                    { 38, 38, 14 },
                    { 36, 36, 6 },
                    { 35, 35, 11 },
                    { 34, 34, 16 },
                    { 33, 33, 3 },
                    { 32, 32, 8 },
                    { 31, 31, 18 },
                    { 30, 30, 13 },
                    { 29, 29, 6 },
                    { 28, 28, 17 },
                    { 27, 27, 14 },
                    { 37, 37, 2 },
                    { 100, 100, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
