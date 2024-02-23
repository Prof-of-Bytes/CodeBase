using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    //composite key
    [PrimaryKey(nameof(OrderId), nameof(GameRealId))]
    public class OrderLine
    {
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public int GameRealId { get; set; }
        public GameReal GameReal { get; set; } = null!;

        public int Quantity { get; set; }

        [DataType(DataType.Currency)]
        [Precision(6, 2)]
        public decimal? SubTotal { get; set; }
    }
}



