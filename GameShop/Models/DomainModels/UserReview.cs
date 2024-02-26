using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{
    [PrimaryKey(nameof(RatingId), nameof(CustomerId))]
    public class UserReview
    {

        public int RatingId { get; set; }
        public Rating Rating { get; set; } = null!;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ReviewDate { get; set; }

        [Range(1, 5)]
        public int Score { get; set; }

        [Column(TypeName = "NVARCHAR(500)")]
        public string ReviewText { get; set; } = string.Empty;
    }
}
