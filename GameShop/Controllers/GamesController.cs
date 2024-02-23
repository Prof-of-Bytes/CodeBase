using GameShop.Models;
using Microsoft.AspNetCore.Mvc;



namespace GameShop.Controllers
{
    public class GamesController : Controller
    {
        private Repository<Game> _gameData { get; set; }

        public GamesController(GameStoreContext context) => _gameData = new Repository<Game>(context);


        public IActionResult Index() => RedirectToAction("List");

        public IActionResult List(GameGridData values)
        {
            var options = new QueryOptions<Game>
            {
                Includes = "Genre, Publisher",
                PageNumber = values.PageNumber,
                PageSize = values.PageSize,
                OrderByDirection = values.SortDirection
            };

            if (values.IsSortByTitle)
                options.OrderBy = a => a.Title;
            else
                options.OrderBy = a => a.Genre;

            var vm = new GamesListViewModel
            {
                Games = _gameData.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(_gameData.Count)
            };
            return View(vm);
        }
        public IActionResult Details(int id)
        {
            var game = _gameData.Get(new QueryOptions<Game>
            {
                Where = a => a.GameId == id,
                Includes = "Genre, Publisher"
            }) ?? new Game();
            return View(game);
        }
    }
}
