namespace TheMerchShop.Models
{
    // Represents a physical location where inventory is stored.
    public class Warehouse
    {
        public int WarehouseID { get; set; } // Primary key
        public string Location { get; set; } = string.Empty; // Location/address of the warehouse

        // Navigation properties
        public virtual ICollection<Inventory> Inventories { get; set; } = new HashSet<Inventory>(); // Inventory stored in the warehouse
    }
}