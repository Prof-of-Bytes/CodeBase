namespace TheMerchShop.Models
{
    // Represents the details of items within an order.
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Primary key
        public int OrderID { get; set; } // Foreign key to Order
        public int MerchID { get; set; } // Foreign key to Merch
        public int Quantity { get; set; } // Quantity of the merchandise item ordered
        public decimal Price { get; set; } // Price of the merchandise item at the time of the order

        // Navigation properties
        public virtual Order Order { get; set; } = null!; // The order this detail belongs to
        public virtual Merch Merch { get; set; } = null!; // The merchandise item ordered
    }
}