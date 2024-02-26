
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GameShop.Models
{
    public class Customer(string firstName, string lastName, string emailAddress, string? userIdentity)
    {
        public int CustomerId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string FirstName { get; set; } = firstName;


        [Column(TypeName = "NVARCHAR(50)")]
        public string LastName { get; set; } = lastName;

        [RegularExpression(@"^[\w]+@[\w]+\.[\w]+$")]
        public string EmailAddress { get; set; } = emailAddress;

        [Column(TypeName = "nvarchar(450)")]
        public string? UserIdentity { get; set; } = userIdentity;
        public GameShopUser CustomerUserLink { get; set; } = null!;
        //From 
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<UserReview> UserReviews { get; set; } = new HashSet<UserReview>();
    }
}