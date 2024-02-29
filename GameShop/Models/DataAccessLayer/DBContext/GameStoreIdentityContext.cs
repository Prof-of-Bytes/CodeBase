using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameShop.Models
{
    public class GameStoreIdentityContext : IdentityDbContext<GameShopUser>
    {
        public GameStoreIdentityContext(DbContextOptions<GameStoreIdentityContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //new GameStoreConfiguration(modelBuilder);
        }
    }
}
