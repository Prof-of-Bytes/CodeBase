

namespace GameShop.Models
{

    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; } = new HashSet<Game>();
        public GameGridData CurrentRoute { get; set; } = new GameGridData();
        public int TotalPages { get; set; }
    }
}
