using System.Text.RegularExpressions;

namespace TheMerchShop.Models
{
    // Represents a vendor who supplies merchandise.
    public class Vendor
    {
        public int VendorID { get; set; } // Primary key
        public string Name { get; set; } = string.Empty; // Vendor's name
        public string WebURL { get; set; } = string.Empty; // Vendor's website URL
        public float OverallRating { get; set; } // Overall rating received from customer reviews

        // Navigation properties
        public virtual ICollection<Merch> Merchandise { get; set; } = new HashSet<Merch>(); // Merchandise supplied by the vendor
        public virtual ICollection<VendorReview> VendorReviews { get; set; } = new HashSet<VendorReview>(); // Reviews for the vendor
    }
}
