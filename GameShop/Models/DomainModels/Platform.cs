using System.ComponentModel.DataAnnotations.Schema;

namespace GameShop.Models
{

    public enum Manufacturer
    {
        MICROSOFT,
        NINTENDO,
        SONY,
        SEGA,
        VALVE

    }

    public class Platform
    {

        public int PlatformId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string PlatformName { get; set; } = string.Empty;

        public Manufacturer Manufacturer { get; set; } 

        //inverse property
        public ICollection<GameReal> GamesReal { get; set; } = new HashSet<GameReal>();

    }
}
