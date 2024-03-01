namespace TheMerchShop.Models
{
    // Represents an order placed by a customer.
    public class Order
    {
        public int OrderID { get; set; } // Primary key
        public int CustomerID { get; set; } // Foreign key to Customer
        public DateTime Date { get; set; } // Date the order was placed
        public decimal Total { get; set; } // Total price of the order

        // Navigation properties
        public virtual Customer Customer { get; set; } = null!; // The customer who placed the order
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new HashSet<OrderDetail>(); // Details of items in the order
    }
}