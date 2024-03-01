using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TheMerchShop.Models;
namespace TheMerchShop.DataAccess
{
    public class MerchShopContext : DbContext
    {
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorReview> VendorReviews { get; set; }
        public DbSet<Merch> Merch { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MerchReview> MerchReviews { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public MerchShopContext(DbContextOptions<MerchShopContext> options) : base(options) {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed initial Customer Data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
                new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" },
                new Customer { CustomerID = 3, FirstName = "Emily", LastName = "Jones", Email = "emily.jones@example.com" },
                new Customer { CustomerID = 4, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com" },
                new Customer { CustomerID = 5, FirstName = "Chris", LastName = "Davis", Email = "chris.davis@example.com" },
                new Customer { CustomerID = 6, FirstName = "Jessica", LastName = "Wilson", Email = "jessica.wilson@example.com" },
                new Customer { CustomerID = 7, FirstName = "David", LastName = "Martinez", Email = "david.martinez@example.com" },
                new Customer { CustomerID = 8, FirstName = "Sarah", LastName = "Miller", Email = "sarah.miller@example.com" },
                new Customer { CustomerID = 9, FirstName = "James", LastName = "Taylor", Email = "james.taylor@example.com" },
                new Customer { CustomerID = 10, FirstName = "Linda", LastName = "Anderson", Email = "linda.anderson@example.com" }
                
            );

            //Seed Vendor Data
            modelBuilder.Entity<Vendor>().HasData(
                new Vendor { VendorID = 1, Name = "Global Tech", WebURL = "http://globaltech.com", OverallRating = 4.5f },
                new Vendor { VendorID = 2, Name = "Innovative Solutions", WebURL = "http://innovativesolutions.com", OverallRating = 4.7f },
                new Vendor { VendorID = 3, Name = "Eco Friendly Merch", WebURL = "http://ecofriendlymerch.com", OverallRating = 4.8f },
                new Vendor { VendorID = 4, Name = "Tech Pioneers", WebURL = "http://techpioneers.com", OverallRating = 4.6f },
                new Vendor { VendorID = 5, Name = "Home Essentials Inc.", WebURL = "http://homeessentialsinc.com", OverallRating = 4.4f },
                new Vendor { VendorID = 6, Name = "Fashion Forward", WebURL = "http://fashionforward.com", OverallRating = 4.9f },
                new Vendor { VendorID = 7, Name = "Gadget Gurus", WebURL = "http://gadgetgurus.com", OverallRating = 4.3f },
                new Vendor { VendorID = 8, Name = "Outdoor Adventures Gear", WebURL = "http://outdooradventuresgear.com", OverallRating = 4.7f },
                new Vendor { VendorID = 9, Name = "Kitchen Kings", WebURL = "http://kitchenkings.com", OverallRating = 4.2f },
                new Vendor { VendorID = 10, Name = "Beauty and Beyond", WebURL = "http://beautyandbeyond.com", OverallRating = 4.8f }
            );

            //seed warehouse
            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { WarehouseID = 1, Location = "North Warehouse, 1234 North St, City A" },
                new Warehouse { WarehouseID = 2, Location = "South Warehouse, 5678 South Rd, City B" },
                new Warehouse { WarehouseID = 3, Location = "East Warehouse, 91011 East Ave, City C" },
                new Warehouse { WarehouseID = 4, Location = "West Warehouse, 121314 West Ln, City D" },
                new Warehouse { WarehouseID = 5, Location = "Central Warehouse, 151617 Central Blvd, City E" }
            );

            //Seed Merch
            modelBuilder.Entity<Merch>().HasData(
                new Merch { MerchID = 1, VendorID = 1, Type = "Electronics", ItemName = "Smartphone", Rating = 4.5f, ItemDescription = "Latest model with high performance." },
                new Merch { MerchID = 2, VendorID = 1, Type = "Electronics", ItemName = "Laptop", Rating = 4.7f, ItemDescription = "Lightweight and powerful, perfect for work and play." },
                new Merch { MerchID = 3, VendorID = 2, Type = "Home Appliances", ItemName = "Microwave Oven", Rating = 4.4f, ItemDescription = "Efficient and easy to use microwave oven." },
                new Merch { MerchID = 4, VendorID = 2, Type = "Home Appliances", ItemName = "Blender", Rating = 4.6f, ItemDescription = "High-speed blender for your kitchen needs." },
                new Merch { MerchID = 5, VendorID = 3, Type = "Fashion", ItemName = "T-Shirt", Rating = 4.8f, ItemDescription = "Comfortable and stylish T-shirt." },
                new Merch { MerchID = 6, VendorID = 3, Type = "Fashion", ItemName = "Jeans", Rating = 4.9f, ItemDescription = "Durable and fashionable jeans." },
                new Merch { MerchID = 7, VendorID = 4, Type = "Books", ItemName = "Sci-Fi Novel", Rating = 4.5f, ItemDescription = "Exciting Sci-Fi novel with thrilling adventures." },
                new Merch { MerchID = 8, VendorID = 4, Type = "Books", ItemName = "Cookbook", Rating = 4.3f, ItemDescription = "Recipes from around the world." },
                new Merch { MerchID = 9, VendorID = 5, Type = "Outdoor", ItemName = "Tent", Rating = 4.7f, ItemDescription = "Spacious and easy-to-set-up tent." },
                new Merch { MerchID = 10, VendorID = 5, Type = "Outdoor", ItemName = "Sleeping Bag", Rating = 4.6f, ItemDescription = "Warm and comfortable sleeping bag." },
                new Merch { MerchID = 11, VendorID = 6, Type = "Electronics", ItemName = "Earbuds", Rating = 4.5f, ItemDescription = "Wireless earbuds with excellent sound quality." },
                new Merch { MerchID = 12, VendorID = 6, Type = "Electronics", ItemName = "E-Reader", Rating = 4.8f, ItemDescription = "E-reader for all your books in one place." },
                new Merch { MerchID = 13, VendorID = 7, Type = "Home Appliances", ItemName = "Electric Kettle", Rating = 4.7f, ItemDescription = "Fast boiling electric kettle." },
                new Merch { MerchID = 14, VendorID = 7, Type = "Home Appliances", ItemName = "Toaster", Rating = 4.5f, ItemDescription = "Efficient and multi-functional toaster." },
                new Merch { MerchID = 15, VendorID = 8, Type = "Fashion", ItemName = "Sneakers", Rating = 4.9f, ItemDescription = "Comfortable and stylish sneakers." },
                new Merch { MerchID = 16, VendorID = 8, Type = "Fashion", ItemName = "Backpack", Rating = 4.8f, ItemDescription = "Durable backpack for all your needs." },
                new Merch { MerchID = 17, VendorID = 9, Type = "Books", ItemName = "Mystery Novel", Rating = 4.6f, ItemDescription = "Gripping mystery novel that keeps you guessing." },
                new Merch { MerchID = 18, VendorID = 9, Type = "Books", ItemName = "Historical Fiction", Rating = 4.7f, ItemDescription = "Fascinating historical fiction novel." },
                new Merch { MerchID = 19, VendorID = 10, Type = "Outdoor", ItemName = "Hiking Boots", Rating = 4.8f, ItemDescription = "Rugged and comfortable hiking boots." },
                new Merch { MerchID = 20, VendorID = 10, Type = "Outdoor", ItemName = "Camping Stove", Rating = 4.5f, ItemDescription = "Portable and easy-to-use camping stove." },
                new Merch { MerchID = 21, VendorID = 1, Type = "Electronics", ItemName = "Tablet", Rating = 4.6f, ItemDescription = "High-resolution screen and long battery life." },
                new Merch { MerchID = 22, VendorID = 2, Type = "Home Appliances", ItemName = "Vacuum Cleaner", Rating = 4.5f, ItemDescription = "Powerful and lightweight vacuum cleaner." },
                new Merch { MerchID = 23, VendorID = 3, Type = "Fashion", ItemName = "Dress", Rating = 4.7f, ItemDescription = "Elegant and comfortable dress." },
                new Merch { MerchID = 24, VendorID = 4, Type = "Books", ItemName = "Fantasy Novel", Rating = 4.8f, ItemDescription = "Epic fantasy novel with a captivating world." },
                new Merch { MerchID = 25, VendorID = 5, Type = "Outdoor", ItemName = "Flashlight", Rating = 4.6f, ItemDescription = "Bright and durable flashlight." },
                new Merch { MerchID = 26, VendorID = 6, Type = "Electronics", ItemName = "Camera", Rating = 4.7f, ItemDescription = "High-quality camera for photography enthusiasts." },
                new Merch { MerchID = 27, VendorID = 7, Type = "Home Appliances", ItemName = "Air Fryer", Rating = 4.5f, ItemDescription = "Healthy cooking with less oil." },
                new Merch { MerchID = 28, VendorID = 8, Type = "Fashion", ItemName = "Hat", Rating = 4.8f, ItemDescription = "Stylish hat suitable for all seasons." },
                new Merch { MerchID = 29, VendorID = 9, Type = "Books", ItemName = "Self-help Book", Rating = 4.9f, ItemDescription = "Inspirational self-help book for personal growth." },
                new Merch { MerchID = 30, VendorID = 10, Type = "Outdoor", ItemName = "Water Bottle", Rating = 4.7f, ItemDescription = "Insulated water bottle to keep drinks at the right temperature." }
            );

            //seed Variant
            modelBuilder.Entity<Variant>().HasData(
                new Variant { VariantID = 1, MerchID = 1, Color = "Black", Size = "64GB" },
                new Variant { VariantID = 2, MerchID = 1, Color = "White", Size = "128GB" },
                new Variant { VariantID = 3, MerchID = 2, Color = "Silver", Size = "256GB" },
                new Variant { VariantID = 4, MerchID = 5, Color = "Blue", Size = "M" },
                new Variant { VariantID = 5, MerchID = 5, Color = "Green", Size = "L" },
                new Variant { VariantID = 6, MerchID = 6, Color = "Black", Size = "32" },
                new Variant { VariantID = 7, MerchID = 6, Color = "Blue", Size = "34" },
                new Variant { VariantID = 8, MerchID = 20, Color = "Red", Size = "One Size" },
                new Variant { VariantID = 9, MerchID = 25, Color = "Black", Size = "One Size" },
                new Variant { VariantID = 10, MerchID = 30, Color = "Blue", Size = "One Size" }
            );

            //seed Inventory
            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { InventoryId = 1, MerchID = 1, WarehouseID = 1, Quantity = 150, PurchaseDate = DateTime.Parse("2023-01-15"), PurchasePrice = 299.99m, SalePrice = 349.99m },
                new Inventory { InventoryId = 2, MerchID = 2, WarehouseID = 1, Quantity = 120, PurchaseDate = DateTime.Parse("2023-02-10"), PurchasePrice = 499.99m, SalePrice = 549.99m },
                new Inventory { InventoryId = 3, MerchID = 3, WarehouseID = 2, Quantity = 100, PurchaseDate = DateTime.Parse("2023-03-05"), PurchasePrice = 199.99m, SalePrice = 249.99m },
                new Inventory { InventoryId = 4, MerchID = 4, WarehouseID = 2, Quantity = 90, PurchaseDate = DateTime.Parse("2023-04-20"), PurchasePrice = 99.99m, SalePrice = 149.99m },
                new Inventory { InventoryId = 5, MerchID = 5, WarehouseID = 3, Quantity = 200, PurchaseDate = DateTime.Parse("2023-05-15"), PurchasePrice = 19.99m, SalePrice = 29.99m },
                new Inventory { InventoryId = 6, MerchID = 6, WarehouseID = 3, Quantity = 180, PurchaseDate = DateTime.Parse("2023-06-10"), PurchasePrice = 29.99m, SalePrice = 39.99m },
                new Inventory { InventoryId = 7, MerchID = 7, WarehouseID = 4, Quantity = 160, PurchaseDate = DateTime.Parse("2023-07-05"), PurchasePrice = 15.99m, SalePrice = 19.99m },
                new Inventory { InventoryId = 8, MerchID = 8, WarehouseID = 4, Quantity = 140, PurchaseDate = DateTime.Parse("2023-08-20"), PurchasePrice = 10.99m, SalePrice = 14.99m },
                new Inventory { InventoryId = 9, MerchID = 9, WarehouseID = 5, Quantity = 130, PurchaseDate = DateTime.Parse("2023-09-15"), PurchasePrice = 499.99m, SalePrice = 599.99m },
                new Inventory { InventoryId = 10, MerchID = 10, WarehouseID = 5, Quantity = 110, PurchaseDate = DateTime.Parse("2023-10-10"), PurchasePrice = 699.99m, SalePrice = 799.99m },
                new Inventory { InventoryId = 11, MerchID = 11, WarehouseID = 1, Quantity = 105, PurchaseDate = DateTime.Parse("2023-02-12"), PurchasePrice = 249.99m, SalePrice = 299.99m },
                new Inventory { InventoryId = 12, MerchID = 12, WarehouseID = 2, Quantity = 95, PurchaseDate = DateTime.Parse("2023-03-18"), PurchasePrice = 349.99m, SalePrice = 399.99m },
                new Inventory { InventoryId = 13, MerchID = 13, WarehouseID = 3, Quantity = 85, PurchaseDate = DateTime.Parse("2023-04-22"), PurchasePrice = 150.99m, SalePrice = 200.99m },
                new Inventory { InventoryId = 14, MerchID = 14, WarehouseID = 4, Quantity = 75, PurchaseDate = DateTime.Parse("2023-05-26"), PurchasePrice = 75.99m, SalePrice = 95.99m },
                new Inventory { InventoryId = 15, MerchID = 15, WarehouseID = 5, Quantity = 65, PurchaseDate = DateTime.Parse("2023-06-30"), PurchasePrice = 225.99m, SalePrice = 275.99m },
                new Inventory { InventoryId = 16, MerchID = 16, WarehouseID = 1, Quantity = 55, PurchaseDate = DateTime.Parse("2023-08-04"), PurchasePrice = 125.99m, SalePrice = 165.99m },
                new Inventory { InventoryId = 17, MerchID = 17, WarehouseID = 2, Quantity = 45, PurchaseDate = DateTime.Parse("2023-09-08"), PurchasePrice = 45.99m, SalePrice = 55.99m },
                new Inventory { InventoryId = 18, MerchID = 18, WarehouseID = 3, Quantity = 35, PurchaseDate = DateTime.Parse("2023-10-13"), PurchasePrice = 30.99m, SalePrice = 40.99m },
                new Inventory { InventoryId = 19, MerchID = 19, WarehouseID = 4, Quantity = 25, PurchaseDate = DateTime.Parse("2023-11-17"), PurchasePrice = 500.99m, SalePrice = 600.99m },
                new Inventory { InventoryId = 20, MerchID = 20, WarehouseID = 5, Quantity = 15, PurchaseDate = DateTime.Parse("2023-12-21"), PurchasePrice = 700.99m, SalePrice = 800.99m },
                new Inventory { InventoryId = 21, MerchID = 21, WarehouseID = 1, Quantity = 120, PurchaseDate = DateTime.Parse("2023-03-14"), PurchasePrice = 250.00m, SalePrice = 300.00m },
                new Inventory { InventoryId = 22, MerchID = 22, WarehouseID = 2, Quantity = 110, PurchaseDate = DateTime.Parse("2023-04-19"), PurchasePrice = 60.00m, SalePrice = 80.00m },
                new Inventory { InventoryId = 23, MerchID = 23, WarehouseID = 3, Quantity = 100, PurchaseDate = DateTime.Parse("2023-05-24"), PurchasePrice = 45.00m, SalePrice = 55.00m },
                new Inventory { InventoryId = 24, MerchID = 24, WarehouseID = 4, Quantity = 90, PurchaseDate = DateTime.Parse("2023-06-29"), PurchasePrice = 12.00m, SalePrice = 18.00m },
                new Inventory { InventoryId = 25, MerchID = 25, WarehouseID = 5, Quantity = 80, PurchaseDate = DateTime.Parse("2023-08-03"), PurchasePrice = 320.00m, SalePrice = 370.00m },
                new Inventory { InventoryId = 26, MerchID = 26, WarehouseID = 1, Quantity = 70, PurchaseDate = DateTime.Parse("2023-09-07"), PurchasePrice = 215.00m, SalePrice = 265.00m },
                new Inventory { InventoryId = 27, MerchID = 27, WarehouseID = 2, Quantity = 60, PurchaseDate = DateTime.Parse("2023-10-12"), PurchasePrice = 190.00m, SalePrice = 240.00m },
                new Inventory { InventoryId = 28, MerchID = 28, WarehouseID = 3, Quantity = 50, PurchaseDate = DateTime.Parse("2023-11-16"), PurchasePrice = 300.00m, SalePrice = 350.00m },
                new Inventory { InventoryId = 29, MerchID = 29, WarehouseID = 4, Quantity = 40, PurchaseDate = DateTime.Parse("2023-12-21"), PurchasePrice = 25.00m, SalePrice = 30.00m },
                new Inventory { InventoryId = 30, MerchID = 30, WarehouseID = 5, Quantity = 30, PurchaseDate = DateTime.Parse("2024-01-25"), PurchasePrice = 400.00m, SalePrice = 450.00m }
            );

            //seed Order
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, CustomerID = 1, Date = DateTime.Parse("2023-01-15"), Total = 299.99m },
                new Order { OrderID = 2, CustomerID = 2, Date = DateTime.Parse("2023-01-20"), Total = 549.99m },
                new Order { OrderID = 3, CustomerID = 3, Date = DateTime.Parse("2023-01-25"), Total = 249.99m },
                new Order { OrderID = 4, CustomerID = 4, Date = DateTime.Parse("2023-02-01"), Total = 149.99m },
                new Order { OrderID = 5, CustomerID = 5, Date = DateTime.Parse("2023-02-05"), Total = 29.99m },
                new Order { OrderID = 6, CustomerID = 6, Date = DateTime.Parse("2023-02-10"), Total = 39.99m },
                new Order { OrderID = 7, CustomerID = 7, Date = DateTime.Parse("2023-02-15"), Total = 19.99m },
                new Order { OrderID = 8, CustomerID = 8, Date = DateTime.Parse("2023-02-20"), Total = 14.99m },
                new Order { OrderID = 9, CustomerID = 9, Date = DateTime.Parse("2023-02-25"), Total = 599.99m },
                new Order { OrderID = 10, CustomerID = 10, Date = DateTime.Parse("2023-03-01"), Total = 799.99m }
            );

            //Seed OrderDetail
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderDetailID = 1, OrderID = 1, MerchID = 1, Quantity = 1, Price = 299.99m },
                new OrderDetail { OrderDetailID = 2, OrderID = 1, MerchID = 2, Quantity = 2, Price = 549.99m },
                new OrderDetail { OrderDetailID = 3, OrderID = 2, MerchID = 3, Quantity = 1, Price = 249.99m },
                new OrderDetail { OrderDetailID = 4, OrderID = 3, MerchID = 4, Quantity = 1, Price = 149.99m },
                new OrderDetail { OrderDetailID = 5, OrderID = 4, MerchID = 5, Quantity = 3, Price = 29.99m },
                new OrderDetail { OrderDetailID = 6, OrderID = 5, MerchID = 6, Quantity = 2, Price = 39.99m },
                new OrderDetail { OrderDetailID = 7, OrderID = 6, MerchID = 7, Quantity = 1, Price = 19.99m },
                new OrderDetail { OrderDetailID = 8, OrderID = 7, MerchID = 8, Quantity = 1, Price = 14.99m },
                new OrderDetail { OrderDetailID = 9, OrderID = 8, MerchID = 9, Quantity = 1, Price = 599.99m },
                new OrderDetail { OrderDetailID = 10, OrderID = 9, MerchID = 10, Quantity = 1, Price = 799.99m },
                new OrderDetail { OrderDetailID = 11, OrderID = 10, MerchID = 11, Quantity = 1, Price = 250.00m },
                new OrderDetail { OrderDetailID = 12, OrderID = 10, MerchID = 12, Quantity = 2, Price = 350.00m },
                new OrderDetail { OrderDetailID = 13, OrderID = 2, MerchID = 13, Quantity = 2, Price = 150.00m },
                new OrderDetail { OrderDetailID = 14, OrderID = 3, MerchID = 14, Quantity = 3, Price = 75.00m },
                new OrderDetail { OrderDetailID = 15, OrderID = 4, MerchID = 15, Quantity = 1, Price = 225.00m },
                new OrderDetail { OrderDetailID = 16, OrderID = 5, MerchID = 16, Quantity = 2, Price = 125.00m },
                new OrderDetail { OrderDetailID = 17, OrderID = 6, MerchID = 17, Quantity = 1, Price = 45.00m },
                new OrderDetail { OrderDetailID = 18, OrderID = 7, MerchID = 18, Quantity = 1, Price = 30.00m },
                new OrderDetail { OrderDetailID = 19, OrderID = 8, MerchID = 19, Quantity = 1, Price = 500.00m },
                new OrderDetail { OrderDetailID = 20, OrderID = 9, MerchID = 20, Quantity = 1, Price = 700.00m }
            );

            //Seed MerchReview
            modelBuilder.Entity<MerchReview>().HasData(
                new MerchReview { MerchReviewID = 1, CustomerID = 1, MerchID = 1, Date = DateTime.Parse("2023-02-15"), ReviewScore = 5, ReviewText = "Incredible performance and battery life!" },
                new MerchReview { MerchReviewID = 2, CustomerID = 2, MerchID = 2, Date = DateTime.Parse("2023-02-17"), ReviewScore = 4, ReviewText = "Great laptop, but a bit pricey." },
                new MerchReview { MerchReviewID = 3, CustomerID = 3, MerchID = 3, Date = DateTime.Parse("2023-02-19"), ReviewScore = 4, ReviewText = "Heats quickly, very efficient." },
                new MerchReview { MerchReviewID = 4, CustomerID = 4, MerchID = 4, Date = DateTime.Parse("2023-02-21"), ReviewScore = 3, ReviewText = "Good but not the best on the market." },
                new MerchReview { MerchReviewID = 5, CustomerID = 5, MerchID = 5, Date = DateTime.Parse("2023-02-23"), ReviewScore = 5, ReviewText = "Love the design and feel!" },
                new MerchReview { MerchReviewID = 6, CustomerID = 6, MerchID = 6, Date = DateTime.Parse("2023-02-25"), ReviewScore = 5, ReviewText = "Very comfortable and durable." },
                new MerchReview { MerchReviewID = 7, CustomerID = 7, MerchID = 7, Date = DateTime.Parse("2023-02-27"), ReviewScore = 4, ReviewText = "Captivating story, couldn't put it down!" },
                new MerchReview { MerchReviewID = 8, CustomerID = 8, MerchID = 8, Date = DateTime.Parse("2023-03-01"), ReviewScore = 3, ReviewText = "Useful, but lacks some features." },
                new MerchReview { MerchReviewID = 9, CustomerID = 9, MerchID = 9, Date = DateTime.Parse("2023-03-03"), ReviewScore = 5, ReviewText = "Perfect for my camping trips!" },
                new MerchReview { MerchReviewID = 10, CustomerID = 10, MerchID = 10, Date = DateTime.Parse("2023-03-05"), ReviewScore = 4, ReviewText = "Good quality, but a bit overpriced." }
            );

            //Seed Vendor Review
            modelBuilder.Entity<VendorReview>().HasData(
                new VendorReview { VendorReviewID = 1, CustomerID = 1, VendorID = 1, Date = DateTime.Parse("2023-01-10"), ReviewScore = 5, ReviewText = "Outstanding service and product quality!" },
                new VendorReview { VendorReviewID = 2, CustomerID = 2, VendorID = 2, Date = DateTime.Parse("2023-01-12"), ReviewScore = 4, ReviewText = "Very good overall, though shipping was slower than expected." },
                new VendorReview { VendorReviewID = 3, CustomerID = 3, VendorID = 3, Date = DateTime.Parse("2023-01-14"), ReviewScore = 5, ReviewText = "Amazing selection of fashion items!" },
                new VendorReview { VendorReviewID = 4, CustomerID = 4, VendorID = 4, Date = DateTime.Parse("2023-01-16"), ReviewScore = 5, ReviewText = "Books arrived quickly and in perfect condition." },
                new VendorReview { VendorReviewID = 5, CustomerID = 5, VendorID = 5, Date = DateTime.Parse("2023-01-18"), ReviewScore = 4, ReviewText = "Great products but customer service could be improved." },
                new VendorReview { VendorReviewID = 6, CustomerID = 6, VendorID = 6, Date = DateTime.Parse("2023-01-20"), ReviewScore = 5, ReviewText = "The electronics are top-notch and reasonably priced." },
                new VendorReview { VendorReviewID = 7, CustomerID = 7, VendorID = 7, Date = DateTime.Parse("2023-01-22"), ReviewScore = 3, ReviewText = "Decent quality, but I had issues with my order." },
                new VendorReview { VendorReviewID = 8, CustomerID = 8, VendorID = 8, Date = DateTime.Parse("2023-01-24"), ReviewScore = 4, ReviewText = "Good value for the money, will shop again." },
                new VendorReview { VendorReviewID = 9, CustomerID = 9, VendorID = 9, Date = DateTime.Parse("2023-01-26"), ReviewScore = 5, ReviewText = "Fantastic customer support and fast delivery." },
                new VendorReview { VendorReviewID = 10, CustomerID = 10, VendorID = 10, Date = DateTime.Parse("2023-01-28"), ReviewScore = 4, ReviewText = "Products are great, but the website is a bit clunky." }
            );






            // Include modelBuilder configurations for other entities



            base.OnModelCreating(modelBuilder);
        }
    }
}
