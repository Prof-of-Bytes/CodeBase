using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{
    public class Game
    {
        //primary key by convention
        public int GameId { get; set; }

        //One to many
        public int GenreId { get; set; }
        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        //One to many
        public int PublisherId { get; set; }
        [ValidateNever]
        public Publisher Publisher { get; set; } = null!;

        [Required]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Title { get; set; } = string.Empty;

        //Many to one
        public ICollection<GameReal> GamesReal { get; set; } = new HashSet<GameReal>();
    }

}
