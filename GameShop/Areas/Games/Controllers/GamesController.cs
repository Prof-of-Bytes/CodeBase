using GameShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace GameShop.Controllers
{
    [Area("Games")]
    [Authorize(Roles="Admin")]
    public class GamesController : Controller
    {
        private Repository<Game> _gameData { get; set; }
        private GameStoreContext _context { get; set; }

        public GamesController(GameStoreContext context)
        {
            _context = context;
            _gameData = new Repository<Game>(context);
        }

        public IActionResult Index() => RedirectToAction("List");

       
        public IActionResult List (int PageNumber=1, int PageSize=4, string SortDirection="asc", string SortField="Title")
        {
            GameGridData tempGrid =
                 new GameGridData { PageNumber = PageNumber, PageSize = PageSize, SortDirection = SortDirection, SortField = SortField };

            var options = new QueryOptions<Game>
            {

                Includes = "Genre, Publisher",
                PageNumber = tempGrid.PageNumber,
                PageSize = tempGrid.PageSize,
                OrderByDirection = tempGrid.SortDirection
            };

            if (tempGrid.IsSortByGenre)
            {
                options.OrderBy = a => a.Genre.GenreName;
            }
            else if (tempGrid.IsSortByPublisher)
            {
                options.OrderBy = a => a.Publisher.PublisherName;
            }
            else
                options.OrderBy = a => a.Title;                

            var vm = new GamesListViewModel
            {
                Games = _gameData.List(options),
                CurrentRoute = tempGrid,
                TotalPages = tempGrid.GetTotalPages(_gameData.Count)

            };
            return View(vm);
        }
        
        public IActionResult Details(int id)
        {
            var game = _context.Games.FirstOrDefault(x => x.GameId == id);
            var genres = _context.Genres.OrderBy(g => g.GenreName).ToList();
            var publishers = _context.Publishers.OrderBy(p  => p.PublisherName).ToList();    
            var gdv = new GameDetailView { Game = game??new Game(), Publishers = publishers, Genres = genres };
            return View(gdv);
        }
    }
}
