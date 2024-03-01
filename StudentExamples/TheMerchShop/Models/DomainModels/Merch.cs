namespace TheMerchShop.Models
{
    // Represents an individual merchandise item.
    public class Merch
    {
        public int MerchID { get; set; } // Primary key
        public int VendorID { get; set; } // Foreign key to Vendor
        public string Type { get; set; } = string.Empty; // Type/category of the merchandise
        public string ItemName { get; set; } = string.Empty; // Name of the merchandise item
        public float Rating { get; set; } // Overall rating from customer reviews
        public string ItemDescription { get; set; } = string.Empty; // Description of the merchandise

        // Navigation properties
        public virtual Vendor Vendor { get; set; } = null!; // The vendor supplying the merchandise
        public virtual ICollection<Inventory> Inventories { get; set; } = new HashSet<Inventory>(); // Inventory records for the merchandise
        public virtual ICollection<MerchReview> MerchReviews { get; set; } = new HashSet<MerchReview>(); // Reviews written for the merchandise
        public virtual ICollection<Variant> Variants { get; set; } = new HashSet<Variant>(); // Variants of the merchandise, e.g., size or color
    }
}