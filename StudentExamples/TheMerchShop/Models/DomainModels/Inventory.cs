namespace TheMerchShop.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; } // Primary key
        public int MerchID { get; set; } // Foreign key to Merch
        public int WarehouseID { get; set; } // Foreign key to Warehouse
        public int Quantity { get; set; } // Quantity of the merchandise in stock
        public DateTime PurchaseDate { get; set; } // Date the merchandise was purchased for inventory
        public decimal PurchasePrice { get; set; } // Purchase price of the merchandise
        public decimal SalePrice { get; set; } // Sale price of the merchandise

        // Navigation properties
        public virtual Merch Merch { get; set; } = null!; // The merchandise this inventory record belongs to
        public virtual Warehouse Warehouse { get; set; } = null!; // The warehouse where the merchandise is stored
    }
}