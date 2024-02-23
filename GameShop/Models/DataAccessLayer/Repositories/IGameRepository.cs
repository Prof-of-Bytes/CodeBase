namespace GameShop.Models
{
    public interface IGameRepository : IRepository<Game>
    {
        void Add(string title, Genre genre, Publisher publisher);

    }
}
