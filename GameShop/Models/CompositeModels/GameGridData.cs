using System.Text.Json.Serialization;


namespace GameShop.Models
{
    public class GameGridData : GridData
    {
        public GameGridData() => SortField = nameof(Game.Title);

        [JsonIgnore]
        public bool IsSortByTitle => SortField.EqualsNoCase(nameof(Game.Title));

        [JsonIgnore]
        public bool IsSortByGenre => SortField.EqualsNoCase(nameof(Game.Genre));

        [JsonIgnore]
        public bool IsSortByPublisher => SortField.EqualsNoCase(nameof(Game.Publisher));
    }
}
