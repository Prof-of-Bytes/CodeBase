namespace TheMerchShop.Models
{
    // Represents a review written for a piece of merchandise by a customer.
    public class MerchReview
    {
        public int MerchReviewID { get; set; } // Primary key
        public int MerchID { get; set; } // Foreign key to Merch
        public int CustomerID { get; set; } // Foreign key to Customer
        public DateTime Date { get; set; } // Date the review was written
        public int ReviewScore { get; set; } // Numerical score of the review
        public string ReviewText { get; set; } = string.Empty;  // Text content of the review

        // Navigation properties
        public virtual Merch Merch { get; set; } = null!; // The merchandise being reviewed
        public virtual Customer Customer { get; set; } = null!; // The customer who wrote the review
    }
}