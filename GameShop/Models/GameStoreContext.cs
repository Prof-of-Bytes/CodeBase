using Microsoft.EntityFrameworkCore;


namespace GameShop.Models
{
    public class GameStoreContext : DbContext
    {
        //constructor
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options)
        {

        }
        //Listing all the DbSets. There should be one for each model
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Game> Games { get; set; } 
        public DbSet<GameReal> GamesReal { get; set; } 
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; } 
        public DbSet<Platform> Platforms { get; set; } 
        public DbSet<Publisher> Publishers { get; set; } 
        public DbSet<Rating> Ratings { get; set; } 
        public DbSet<UserReview> UserReviews { get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new GameStoreConfiguration(modelBuilder);
        }
    }
}