using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{ 
    public class Genre
    {
        public int GenreId { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        [Display(Name = "Genre Name")]
        public string GenreName { get; set; } = string.Empty;


        [Column(TypeName = "NVARCHAR(250)")]
        [Display(Name = "Genre Description")]
        public string Description { get; set; } = string.Empty;

        //This is the inverse relationship from Game.cs the collection will be instantiated in the constructor of this class
        public ICollection<Game> Games { get; set; } = new HashSet<Game>();

    }
}