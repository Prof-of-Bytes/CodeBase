namespace TheMerchShop.Models
{
    // Represents a review written about a vendor by a customer.
    public class VendorReview
    {
        public int VendorReviewID { get; set; } // Primary key
        public int VendorID { get; set; } // Foreign key to Vendor
        public int CustomerID { get; set; } // Foreign key to Customer
        public DateTime Date { get; set; } // Date the review was written
        public int ReviewScore { get; set; } // Numerical score of the review
        public string ReviewText { get; set; } = string.Empty;  // Text content of the review

        // Navigation properties
        public virtual Vendor Vendor { get; set; } = null!; // The vendor being reviewed
        public virtual Customer Customer { get; set; } = null!; // The customer who wrote the review
    }
}