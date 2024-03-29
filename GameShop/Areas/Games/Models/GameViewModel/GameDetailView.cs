using System.Collections;
using System.Collections.Generic;

namespace GameShop.Models
{
    public class GameDetailView
    {
        public Game Game { get; set; } = new Game();
        public IEnumerable<Genre> Genres { get; set; } = [];
        public IEnumerable<Publisher> Publishers { get; set; } = [];


    }

}

