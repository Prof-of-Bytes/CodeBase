using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameShop.Models
{
    public class GameStoreConfiguration
    {
        public GameStoreConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new PublisherConfig());
            modelBuilder.ApplyConfiguration(new GameConfig());
            modelBuilder.ApplyConfiguration(new PlatformConfig());
        }


        protected internal class GenreConfig : IEntityTypeConfiguration<Genre>
        {

            public void Configure(EntityTypeBuilder<Genre> entity)
            {
                entity.HasData(
                        new Genre { GenreId = 1, GenreName = "Action", Description = "Engaging and dynamic gameplay with a focus on fast-paced challenges and combat." },
                        new Genre { GenreId = 2, GenreName = "Adventure", Description = "Immersive narratives and exploration, often involving puzzles and a rich storyline." },
                        new Genre { GenreId = 3, GenreName = "Role-Playing Game (RPG)", Description = "Players assume the roles of characters in a fictional world, with a focus on character development and storytelling." },
                        new Genre { GenreId = 4, GenreName = "Strategy", Description = "Tactical decision-making and resource management are key in these games, often involving complex scenarios." },
                        new Genre { GenreId = 5, GenreName = "Simulation", Description = "Realistic or fantasy simulations of various activities, such as life, farming, or city-building." },
                        new Genre { GenreId = 6, GenreName = "Sports", Description = "Virtual representations of real-world sports, offering realistic gameplay and competition." },
                        new Genre { GenreId = 7, GenreName = "Horror", Description = "Designed to evoke fear and suspense, often featuring dark atmospheres and terrifying elements." },
                        new Genre { GenreId = 8, GenreName = "Puzzle", Description = "Brain-teasing challenges and puzzles that require logic and problem-solving skills." },
                        new Genre { GenreId = 9, GenreName = "Sandbox", Description = "Open-world games that allow players to explore and interact with the game environment freely." },
                        new Genre { GenreId = 10, GenreName = "Multiplayer Online Battle Arena (MOBA)", Description = "Team-based competitive games where players control unique characters with distinct abilities in strategic battles." }
                );
            }
        }
        protected internal class PublisherConfig : IEntityTypeConfiguration<Publisher>
        {

            public void Configure(EntityTypeBuilder<Publisher> entity)
            {

                entity.HasData(
                        new Publisher { PublisherId = 1, PublisherName = "Electronic Arts", PublisherURL = "https://www.ea.com" },
                        new Publisher { PublisherId = 2, PublisherName = "Ubisoft", PublisherURL = "https://www.ubisoft.com" },
                        new Publisher { PublisherId = 3, PublisherName = "Activision", PublisherURL = "https://www.activision.com" },
                        new Publisher { PublisherId = 4, PublisherName = "Nintendo", PublisherURL = "https://www.nintendo.com" },
                        new Publisher { PublisherId = 5, PublisherName = "Square Enix", PublisherURL = "https://www.square-enix.com" },
                        new Publisher { PublisherId = 6, PublisherName = "Capcom", PublisherURL = "https://www.capcom.com" },
                        new Publisher { PublisherId = 7, PublisherName = "Bethesda Softworks", PublisherURL = "https://www.bethesda.net" },
                        new Publisher { PublisherId = 8, PublisherName = "Sony Interactive Entertainment", PublisherURL = "https://www.playstation.com" },
                        new Publisher { PublisherId = 9, PublisherName = "Microsoft Studios", PublisherURL = "https://www.microsoft.com" },
                        new Publisher { PublisherId = 10, PublisherName = "CD Projekt", PublisherURL = "https://www.cdprojekt.com" }

                );
            }
        }
        protected internal class GameConfig : IEntityTypeConfiguration<Game>
        {
            public void Configure(EntityTypeBuilder<Game> entity)
            {
                entity.HasData(
                    new Game {GameId=1, GenreId = 2, PublisherId = 4, Title = "The Legend of Zelda: Breath of the Wild" }
                    );
            }
        }
        protected internal class PlatformConfig : IEntityTypeConfiguration<Platform>
        {
            public void Configure(EntityTypeBuilder<Platform> entity)
            {
                entity.HasData(
                    new Platform { PlatformId = 1, Manufacturer = Manufacturer.NINTENDO, PlatformName="Nintendo Switch"}
                    );
            }
        }


    }

}
