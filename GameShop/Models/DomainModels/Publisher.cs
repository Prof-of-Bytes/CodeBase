using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        [Display(Name = " Publisher Name")]
        public string PublisherName { get; set; } = string.Empty;

        [DataType(DataType.Url)]
        public string? PublisherURL { get; set; }

        //inverse property
        public ICollection<Game> Games { get; set; } = new HashSet<Game>();

    }
}