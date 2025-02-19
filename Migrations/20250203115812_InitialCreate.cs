using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    CartItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItem_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Apple Watch Series", "1.jpg", true, "Apple Watch Series 1", 70000m, 100 },
                    { 2, "Samsung's flagship smartphone", "2.jpg", true, "Samsung Galaxy S21", 150000m, 50 },
                    { 3, "Apple's latest iPhone", "3.jpg", true, "iPhone 14 Pro", 200000m, 30 },
                    { 4, "High performance at an affordable price", "4.jpg", true, "Xiaomi Mi 11", 100000m, 70 },
                    { 5, "Foldable smartphone with cutting-edge design", "5.jpg", true, "Samsung Galaxy Z Fold 4", 250000m, 20 },
                    { 6, "Compact and powerful", "6.jpg", true, "iPhone SE (2023)", 80000m, 80 },
                    { 7, "Google's AI-powered smartphone", "7.jpg", true, "Google Pixel 7", 140000m, 40 },
                    { 8, "Fast and smooth flagship experience", "8.jpg", true, "OnePlus 11", 130000m, 60 },
                    { 9, "Compact and professional-grade camera", "9.jpg", true, "Sony Xperia 5 IV", 120000m, 25 },
                    { 10, "Affordable mid-range smartphone", "10.jpg", true, "Samsung Galaxy A53", 50000m, 100 },
                    { 11, "Budget-friendly with great features", "11.jpg", true, "Xiaomi Redmi Note 12", 45000m, 120 },
                    { 12, "Flagship performance for gamers", "12.jpg", true, "Realme GT Neo 3", 110000m, 40 },
                    { 13, "Ultimate gaming phone", "13.jpg", true, "Asus ROG Phone 6", 180000m, 30 },
                    { 14, "Compact and powerful Apple device", "14.jpg", true, "iPhone 13 Mini", 130000m, 50 },
                    { 15, "Fan Edition with flagship features", "15.jpg", true, "Samsung Galaxy S20 FE", 70000m, 90 },
                    { 16, "Flagship photography and design", "16.jpg", true, "Huawei P50 Pro", 160000m, 35 },
                    { 17, "Stylish design with top-notch performance", "17.jpg", true, "Oppo Find X5 Pro", 140000m, 45 },
                    { 18, "High performance and sleek design", "18.jpg", true, "Motorola Edge 30 Ultra", 135000m, 30 },
                    { 19, "Budget-friendly performance device", "19.jpg", true, "Xiaomi Poco F4", 50000m, 100 },
                    { 20, "Classic Apple smartphone", "20.jpg", true, "iPhone 12", 100000m, 70 },
                    { 21, "Ultimate productivity device", "21.jpg", true, "Samsung Galaxy Note 20 Ultra", 170000m, 25 },
                    { 22, "Camera-centric flagship smartphone", "22.jpg", true, "Vivo X80 Pro", 150000m, 40 },
                    { 23, "Rugged and durable smartphone", "23.jpg", true, "Nokia XR20", 60000m, 80 },
                    { 24, "Affordable Google experience", "24.jpg", true, "Google Pixel 6a", 70000m, 90 },
                    { 25, "Premium design and performance", "25.jpg", true, "Honor Magic 4 Pro", 150000m, 40 },
                    { 26, "Gaming smartphone with powerful features", "26.jpg", true, "Xiaomi Black Shark 5", 120000m, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductId",
                table: "CartItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
