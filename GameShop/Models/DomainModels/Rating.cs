using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        //one to one
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;

        [Precision(1, 1)]
        [Range(1, 5)]
        public double? OverallRating { get; set; }

        //many to one
        public ICollection<UserReview> UserReviews { get; set; } = new HashSet<UserReview>();
    }
}

