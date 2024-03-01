using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheMerchShop.Migrations
{
    /// <inheritdoc />
    public partial class dataload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe" },
                    { 2, "jane.smith@example.com", "Jane", "Smith" },
                    { 3, "emily.jones@example.com", "Emily", "Jones" },
                    { 4, "michael.brown@example.com", "Michael", "Brown" },
                    { 5, "chris.davis@example.com", "Chris", "Davis" },
                    { 6, "jessica.wilson@example.com", "Jessica", "Wilson" },
                    { 7, "david.martinez@example.com", "David", "Martinez" },
                    { 8, "sarah.miller@example.com", "Sarah", "Miller" },
                    { 9, "james.taylor@example.com", "James", "Taylor" },
                    { 10, "linda.anderson@example.com", "Linda", "Anderson" }
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "VendorID", "Name", "OverallRating", "WebURL" },
                values: new object[,]
                {
                    { 1, "Global Tech", 4.5f, "http://globaltech.com" },
                    { 2, "Innovative Solutions", 4.7f, "http://innovativesolutions.com" },
                    { 3, "Eco Friendly Merch", 4.8f, "http://ecofriendlymerch.com" },
                    { 4, "Tech Pioneers", 4.6f, "http://techpioneers.com" },
                    { 5, "Home Essentials Inc.", 4.4f, "http://homeessentialsinc.com" },
                    { 6, "Fashion Forward", 4.9f, "http://fashionforward.com" },
                    { 7, "Gadget Gurus", 4.3f, "http://gadgetgurus.com" },
                    { 8, "Outdoor Adventures Gear", 4.7f, "http://outdooradventuresgear.com" },
                    { 9, "Kitchen Kings", 4.2f, "http://kitchenkings.com" },
                    { 10, "Beauty and Beyond", 4.8f, "http://beautyandbeyond.com" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseID", "Location" },
                values: new object[,]
                {
                    { 1, "North Warehouse, 1234 North St, City A" },
                    { 2, "South Warehouse, 5678 South Rd, City B" },
                    { 3, "East Warehouse, 91011 East Ave, City C" },
                    { 4, "West Warehouse, 121314 West Ln, City D" },
                    { 5, "Central Warehouse, 151617 Central Blvd, City E" }
                });

            migrationBuilder.InsertData(
                table: "Merch",
                columns: new[] { "MerchID", "ItemDescription", "ItemName", "Rating", "Type", "VendorID" },
                values: new object[,]
                {
                    { 1, "Latest model with high performance.", "Smartphone", 4.5f, "Electronics", 1 },
                    { 2, "Lightweight and powerful, perfect for work and play.", "Laptop", 4.7f, "Electronics", 1 },
                    { 3, "Efficient and easy to use microwave oven.", "Microwave Oven", 4.4f, "Home Appliances", 2 },
                    { 4, "High-speed blender for your kitchen needs.", "Blender", 4.6f, "Home Appliances", 2 },
                    { 5, "Comfortable and stylish T-shirt.", "T-Shirt", 4.8f, "Fashion", 3 },
                    { 6, "Durable and fashionable jeans.", "Jeans", 4.9f, "Fashion", 3 },
                    { 7, "Exciting Sci-Fi novel with thrilling adventures.", "Sci-Fi Novel", 4.5f, "Books", 4 },
                    { 8, "Recipes from around the world.", "Cookbook", 4.3f, "Books", 4 },
                    { 9, "Spacious and easy-to-set-up tent.", "Tent", 4.7f, "Outdoor", 5 },
                    { 10, "Warm and comfortable sleeping bag.", "Sleeping Bag", 4.6f, "Outdoor", 5 },
                    { 11, "Wireless earbuds with excellent sound quality.", "Earbuds", 4.5f, "Electronics", 6 },
                    { 12, "E-reader for all your books in one place.", "E-Reader", 4.8f, "Electronics", 6 },
                    { 13, "Fast boiling electric kettle.", "Electric Kettle", 4.7f, "Home Appliances", 7 },
                    { 14, "Efficient and multi-functional toaster.", "Toaster", 4.5f, "Home Appliances", 7 },
                    { 15, "Comfortable and stylish sneakers.", "Sneakers", 4.9f, "Fashion", 8 },
                    { 16, "Durable backpack for all your needs.", "Backpack", 4.8f, "Fashion", 8 },
                    { 17, "Gripping mystery novel that keeps you guessing.", "Mystery Novel", 4.6f, "Books", 9 },
                    { 18, "Fascinating historical fiction novel.", "Historical Fiction", 4.7f, "Books", 9 },
                    { 19, "Rugged and comfortable hiking boots.", "Hiking Boots", 4.8f, "Outdoor", 10 },
                    { 20, "Portable and easy-to-use camping stove.", "Camping Stove", 4.5f, "Outdoor", 10 },
                    { 21, "High-resolution screen and long battery life.", "Tablet", 4.6f, "Electronics", 1 },
                    { 22, "Powerful and lightweight vacuum cleaner.", "Vacuum Cleaner", 4.5f, "Home Appliances", 2 },
                    { 23, "Elegant and comfortable dress.", "Dress", 4.7f, "Fashion", 3 },
                    { 24, "Epic fantasy novel with a captivating world.", "Fantasy Novel", 4.8f, "Books", 4 },
                    { 25, "Bright and durable flashlight.", "Flashlight", 4.6f, "Outdoor", 5 },
                    { 26, "High-quality camera for photography enthusiasts.", "Camera", 4.7f, "Electronics", 6 },
                    { 27, "Healthy cooking with less oil.", "Air Fryer", 4.5f, "Home Appliances", 7 },
                    { 28, "Stylish hat suitable for all seasons.", "Hat", 4.8f, "Fashion", 8 },
                    { 29, "Inspirational self-help book for personal growth.", "Self-help Book", 4.9f, "Books", 9 },
                    { 30, "Insulated water bottle to keep drinks at the right temperature.", "Water Bottle", 4.7f, "Outdoor", 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "CustomerID", "Date", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 299.99m },
                    { 2, 2, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 549.99m },
                    { 3, 3, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 249.99m },
                    { 4, 4, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 149.99m },
                    { 5, 5, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.99m },
                    { 6, 6, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 39.99m },
                    { 7, 7, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.99m },
                    { 8, 8, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.99m },
                    { 9, 9, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 599.99m },
                    { 10, 10, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 799.99m }
                });

            migrationBuilder.InsertData(
                table: "VendorReviews",
                columns: new[] { "VendorReviewID", "CustomerID", "Date", "ReviewScore", "ReviewText", "VendorID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Outstanding service and product quality!", 1 },
                    { 2, 2, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Very good overall, though shipping was slower than expected.", 2 },
                    { 3, 3, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Amazing selection of fashion items!", 3 },
                    { 4, 4, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Books arrived quickly and in perfect condition.", 4 },
                    { 5, 5, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Great products but customer service could be improved.", 5 },
                    { 6, 6, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "The electronics are top-notch and reasonably priced.", 6 },
                    { 7, 7, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Decent quality, but I had issues with my order.", 7 },
                    { 8, 8, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Good value for the money, will shop again.", 8 },
                    { 9, 9, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Fantastic customer support and fast delivery.", 9 },
                    { 10, 10, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Products are great, but the website is a bit clunky.", 10 }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "InventoryId", "MerchID", "PurchaseDate", "PurchasePrice", "Quantity", "SalePrice", "WarehouseID" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 299.99m, 150, 349.99m, 1 },
                    { 2, 2, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 499.99m, 120, 549.99m, 1 },
                    { 3, 3, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 199.99m, 100, 249.99m, 2 },
                    { 4, 4, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 99.99m, 90, 149.99m, 2 },
                    { 5, 5, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.99m, 200, 29.99m, 3 },
                    { 6, 6, new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29.99m, 180, 39.99m, 3 },
                    { 7, 7, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.99m, 160, 19.99m, 4 },
                    { 8, 8, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.99m, 140, 14.99m, 4 },
                    { 9, 9, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 499.99m, 130, 599.99m, 5 },
                    { 10, 10, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 699.99m, 110, 799.99m, 5 },
                    { 11, 11, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 249.99m, 105, 299.99m, 1 },
                    { 12, 12, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 349.99m, 95, 399.99m, 2 },
                    { 13, 13, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.99m, 85, 200.99m, 3 },
                    { 14, 14, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 75.99m, 75, 95.99m, 4 },
                    { 15, 15, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 225.99m, 65, 275.99m, 5 },
                    { 16, 16, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 125.99m, 55, 165.99m, 1 },
                    { 17, 17, new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.99m, 45, 55.99m, 2 },
                    { 18, 18, new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 30.99m, 35, 40.99m, 3 },
                    { 19, 19, new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 500.99m, 25, 600.99m, 4 },
                    { 20, 20, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 700.99m, 15, 800.99m, 5 },
                    { 21, 21, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.00m, 120, 300.00m, 1 },
                    { 22, 22, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.00m, 110, 80.00m, 2 },
                    { 23, 23, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 45.00m, 100, 55.00m, 3 },
                    { 24, 24, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.00m, 90, 18.00m, 4 },
                    { 25, 25, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 320.00m, 80, 370.00m, 5 },
                    { 26, 26, new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 215.00m, 70, 265.00m, 1 },
                    { 27, 27, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 190.00m, 60, 240.00m, 2 },
                    { 28, 28, new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 300.00m, 50, 350.00m, 3 },
                    { 29, 29, new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25.00m, 40, 30.00m, 4 },
                    { 30, 30, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 400.00m, 30, 450.00m, 5 }
                });

            migrationBuilder.InsertData(
                table: "MerchReviews",
                columns: new[] { "MerchReviewID", "CustomerID", "Date", "MerchID", "ReviewScore", "ReviewText" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "Incredible performance and battery life!" },
                    { 2, 2, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "Great laptop, but a bit pricey." },
                    { 3, 3, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "Heats quickly, very efficient." },
                    { 4, 4, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3, "Good but not the best on the market." },
                    { 5, 5, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, "Love the design and feel!" },
                    { 6, 6, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5, "Very comfortable and durable." },
                    { 7, 7, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4, "Captivating story, couldn't put it down!" },
                    { 8, 8, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3, "Useful, but lacks some features." },
                    { 9, 9, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, "Perfect for my camping trips!" },
                    { 10, 10, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, "Good quality, but a bit overpriced." }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderDetailID", "MerchID", "OrderID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 299.99m, 1 },
                    { 2, 2, 1, 549.99m, 2 },
                    { 3, 3, 2, 249.99m, 1 },
                    { 4, 4, 3, 149.99m, 1 },
                    { 5, 5, 4, 29.99m, 3 },
                    { 6, 6, 5, 39.99m, 2 },
                    { 7, 7, 6, 19.99m, 1 },
                    { 8, 8, 7, 14.99m, 1 },
                    { 9, 9, 8, 599.99m, 1 },
                    { 10, 10, 9, 799.99m, 1 },
                    { 11, 11, 10, 250.00m, 1 },
                    { 12, 12, 10, 350.00m, 2 },
                    { 13, 13, 2, 150.00m, 2 },
                    { 14, 14, 3, 75.00m, 3 },
                    { 15, 15, 4, 225.00m, 1 },
                    { 16, 16, 5, 125.00m, 2 },
                    { 17, 17, 6, 45.00m, 1 },
                    { 18, 18, 7, 30.00m, 1 },
                    { 19, 19, 8, 500.00m, 1 },
                    { 20, 20, 9, 700.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "VariantID", "Color", "MerchID", "Size" },
                values: new object[,]
                {
                    { 1, "Black", 1, "64GB" },
                    { 2, "White", 1, "128GB" },
                    { 3, "Silver", 2, "256GB" },
                    { 4, "Blue", 5, "M" },
                    { 5, "Green", 5, "L" },
                    { 6, "Black", 6, "32" },
                    { 7, "Blue", 6, "34" },
                    { 8, "Red", 20, "One Size" },
                    { 9, "Black", 25, "One Size" },
                    { 10, "Blue", 30, "One Size" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "InventoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MerchReviews",
                keyColumn: "MerchReviewID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "OrderDetailID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "VariantID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VendorReviews",
                keyColumn: "VendorReviewID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vendors",
                keyColumn: "VendorID",
                keyValue: 10);
        }
    }
}
