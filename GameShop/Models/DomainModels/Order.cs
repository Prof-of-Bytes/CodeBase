using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{ 
    public class Order
    {
        public int OrderId { get; set; }
        //One to many
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Currency)]
        [Precision(10, 2)]
        public decimal? Total { get; set; }

    }
}
