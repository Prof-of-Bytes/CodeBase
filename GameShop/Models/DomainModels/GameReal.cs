using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{
    public class GameReal
    {
        public int GameRealId { get; set; }
        //One to many
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
        //ONe to Many
        public int PlatformId { get; set; }
        public Platform Platform { get; init; } = null!;

        [Column(TypeName = "Integer")]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Precision(6, 2)]
        public decimal PurchasePrice { get; set; }

        [Precision(6, 2)]
        public decimal SalePrice { get; set; }
        //Many to One
        public ICollection<OrderLine> OrderLines = new HashSet<OrderLine>();

    }
}