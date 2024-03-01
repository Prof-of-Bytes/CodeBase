namespace TheMerchShop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } // Primary key
        public string FirstName { get; set; } = string.Empty; // Customer's first name
        public string LastName { get; set; } = string.Empty; // Customer's last name
        public string Email { get; set; } = string.Empty; // Customer's email address

        // Navigation properties
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>(); // Orders placed by the customer
        public virtual ICollection<VendorReview> VendorReviews { get; set; } = new HashSet<VendorReview>(); // Vendor reviews written by the customer
        public virtual ICollection<MerchReview> MerchReviews { get; set; } = new HashSet<MerchReview>(); // Merchandise reviews written by the customer
    }
}