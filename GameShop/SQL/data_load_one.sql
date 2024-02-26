-- Check if data exists in OrderLines table
IF EXISTS (SELECT 1 FROM OrderLines)
BEGIN
    -- Delete data from OrderLines table
    DELETE FROM OrderLines;
END

-- Check if data exists in UserReviews table
IF EXISTS (SELECT 1 FROM UserReviews)
BEGIN
    -- Delete data from UserReviews table
    DELETE FROM UserReviews;
END

-- Check if data exists in Ratings table
IF EXISTS (SELECT 1 FROM Ratings)
BEGIN
    -- Delete data from Ratings table
    DELETE FROM Ratings;
END

-- Check if data exists in GamesReal table
IF EXISTS (SELECT 1 FROM GamesReal)
BEGIN
    -- Delete data from GamesReal table
    DELETE FROM GamesReal;
END

-- Check if data exists in Orders table
IF EXISTS (SELECT 1 FROM Orders)
BEGIN
    -- Delete data from Orders table
    DELETE FROM Orders;
END

-- Check if data exists in Games table
IF EXISTS (SELECT 1 FROM Games)
BEGIN
    -- Delete data from Games table
    DELETE FROM Games;
END

-- Check if data exists in Customers table
IF EXISTS (SELECT 1 FROM Customers)
BEGIN
    -- Delete data from Customers table
    DELETE FROM Customers;
END

-- Check if data exists in Platforms table
IF EXISTS (SELECT 1 FROM Platforms)
BEGIN
    -- Delete data from Platforms table
    DELETE FROM Platforms;
END

-- Check if data exists in Publishers table
IF EXISTS (SELECT 1 FROM Publishers)
BEGIN
    -- Delete data from Publishers table
    DELETE FROM Publishers;
END

-- Check if data exists in Genres table
IF EXISTS (SELECT 1 FROM Genres)
BEGIN
    -- Delete data from Genres table
    DELETE FROM Genres;
END

-- Reset auto-increment IDs after deletion
DBCC CHECKIDENT('Ratings', RESEED, 0);
DBCC CHECKIDENT('GamesReal', RESEED, 0);
DBCC CHECKIDENT('Orders', RESEED, 0);
DBCC CHECKIDENT('Games', RESEED, 0);
DBCC CHECKIDENT('Customers', RESEED, 0);
DBCC CHECKIDENT('Platforms', RESEED, 0);
DBCC CHECKIDENT('Publishers', RESEED, 0);
DBCC CHECKIDENT('Genres', RESEED, 0);

-- Drop existing foreign key constraints
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = 'FOREIGN KEY')
BEGIN
 ALTER TABLE OrderLines DROP CONSTRAINT FK_OrderLines_Orders_OrderId;
    ALTER TABLE OrderLines DROP CONSTRAINT FK_OrderLines_GamesReal_GameRealId;
    ALTER TABLE Ratings DROP CONSTRAINT FK_Ratings_Games_GameId;
    ALTER TABLE GamesReal DROP CONSTRAINT FK_GamesReal_Games_GameId;
    ALTER TABLE GamesReal DROP CONSTRAINT FK_GamesReal_Platforms_PlatformId;
    ALTER TABLE Orders DROP CONSTRAINT FK_Orders_Customers_CustomerId;

    -- Add any additional foreign key constraints here for other tables

    PRINT 'Foreign key constraints have been dropped.';
END

-- Add foreign key constraints
-- Add foreign key constraints
ALTER TABLE OrderLines ADD CONSTRAINT FK_OrderLines_Orders_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(OrderId) ON DELETE CASCADE;
ALTER TABLE OrderLines ADD CONSTRAINT FK_OrderLines_GamesReal_GameRealId FOREIGN KEY (GameRealId) REFERENCES GamesReal(GameRealId) ON DELETE CASCADE;
ALTER TABLE Ratings ADD CONSTRAINT FK_Ratings_Games_GameId FOREIGN KEY (GameId) REFERENCES Games(GameId) ON DELETE CASCADE;
ALTER TABLE GamesReal ADD CONSTRAINT FK_GamesReal_Games_GameId FOREIGN KEY (GameId) REFERENCES Games(GameId) ON DELETE CASCADE;
ALTER TABLE GamesReal ADD CONSTRAINT FK_GamesReal_Platforms_PlatformId FOREIGN KEY (PlatformId) REFERENCES Platforms(PlatformId) ON DELETE CASCADE;
ALTER TABLE Orders ADD CONSTRAINT FK_Orders_Customers_CustomerId FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId) ON DELETE CASCADE;

-- Add any additional foreign key constraints here for other tables

PRINT 'Data has been cleared, and foreign key constraints have been regenerated.';

-- Populate Genres table with 10 entries
INSERT INTO Genres (GenreName, Description) 
VALUES 
    ('Action', 'Games involving physical challenges, often including hand-eye coordination and reaction time'),
    ('Adventure', 'Games that emphasize puzzle solving and exploration'),
    ('Role-Playing', 'Games where players assume the roles of characters in a fictional setting'),
    ('Strategy', 'Games that require strategic thinking and planning'),
    ('Simulation', 'Games that simulate real-world activities or environments'),
    ('Sports', 'Games based on real-world sports activities'),
    ('Racing', 'Games that involve competing in races'),
    ('Puzzle', 'Games that challenge players with puzzles and brainteasers'),
    ('Fighting', 'Games focused on one-on-one combat or martial arts'),
    ('Horror', 'Games designed to create a sense of fear and suspense');


-- Populate Publishers table with real-world publishers
INSERT INTO Publishers (PublisherName, PublisherURL) 
VALUES
    ('Electronic Arts', 'https://www.ea.com/'),
    ('Ubisoft', 'https://www.ubisoft.com/'),
    ('Activision', 'https://www.activision.com/'),
    ('Nintendo', 'https://www.nintendo.com/'),
    ('Bethesda Softworks', 'https://bethesda.net/'),
    ('Square Enix', 'https://www.square-enix-games.com/'),
    ('Sony Interactive Entertainment', 'https://www.playstation.com/'),
    ('Rockstar Games', 'https://www.rockstargames.com/'),
    ('2K Games', 'https://www.2k.com/'),
    ('Bandai Namco Entertainment', 'https://www.bandainamcoent.com/');

INSERT INTO Platforms (PlatformName, Manufacturer) 
VALUES
    ('Xbox Series X', 0),
    ('Nintendo Switch', 1),
    ('PlayStation 5', 2),
    ('PlayStation 4', 2),
    ('PlayStation 3', 2),
    ('Sega Genesis', 3),
    ('Sega Saturn', 3),
    ('Sega Dreamcast', 3),
    ('Steam (PC)', 4),
    ('Valve Index', 4);

-- Populate Games table with real-world games
INSERT INTO Games (GenreId, PublisherId, Title) 
VALUES
    (1, 2, 'Battlefield 2042'),
    (2, 3, 'Far Cry 6'),
    (3, 4, 'The Legend of Zelda: Breath of the Wild'),
    (4, 5, 'Overwatch'),
    (5, 6, 'The Sims 4'),
    (6, 7, 'NBA 2K22'),
    (7, 8, 'Red Dead Redemption 2'),
    (8, 9, 'Kingdom Hearts III'),
    (9, 10, 'Dark Souls III'),
    (10, 1, 'Apex Legends'),
    (1, 3, 'Call of Duty: Vanguard'),
    (2, 4, 'Super Mario Odyssey'),
    (3, 5, 'Fallout 76'),
    (4, 6, 'F1 2021'),
    (5, 7, 'The Last of Us Part II'),
    (6, 8, 'Genshin Impact'),
    (7, 9, 'Horizon Zero Dawn'),
    (8, 10, 'Sekiro: Shadows Die Twice'),
    (9, 1, 'Battlefield 1'),
    (10, 2, 'Rainbow Six Siege'),
    (1, 4, 'Rocket League'),
    (2, 5, 'Minecraft'),
    (3, 6, 'Persona 5'),
    (4, 7, 'Resident Evil Village'),
    (5, 8, 'Ghost of Tsushima'),
    (6, 9, 'Demon''s Souls'),
    (7, 10, 'Dragon Ball FighterZ'),
    (8, 1, 'Destiny 2'),
    (9, 2, 'Assassin''s Creed Odyssey'),
    (10, 3, 'Cyberpunk 2077'),
    (1, 5, 'Stardew Valley'),
    (2, 6, 'Monster Hunter: World'),
    (3, 7, 'The Witcher 3: Wild Hunt'),
    (4, 8, 'Borderlands 3'),
    (5, 9, 'Dead by Daylight'),
    (6, 10, 'Tom Clancy''s Ghost Recon Breakpoint'),
    (7, 1, 'GTA Online'),
    (8, 2, 'Halo Infinite'),
    (9, 3, 'The Division 2'),
    (10, 4, 'Forza Horizon 5');

-- Populate GamesReal table with references from Games
INSERT INTO GamesReal (GameId, PlatformId, Quantity, ReleaseDate, PurchasePrice, SalePrice)
VALUES
    -- Game 1
    (1, 1, 100, '2022-01-01', 59.99, 79.99),
    -- Game 2
    (2, 2, 80, '2021-11-10', 49.99, 69.99),
    -- Game 3
    (3, 3, 120, '2020-11-17', 39.99, 59.99),
    -- Game 4
    (4, 1, 90, '2021-03-05', 54.99, 74.99),
    -- Game 5
    (5, 2, 110, '2020-09-25', 44.99, 64.99),
    -- Game 6
    (6, 3, 70, '2019-10-18', 29.99, 49.99),
    -- Game 7
    (7, 1, 150, '2020-12-10', 49.99, 69.99),
    -- Game 8
    (8, 2, 85, '2019-07-30', 39.99, 59.99),
    -- Game 9
    (9, 3, 95, '2020-04-03', 59.99, 79.99),
    -- Game 10
    (10, 1, 120, '2018-10-26', 34.99, 54.99),
    -- Repeat the above pattern for 40 more games
    -- Game 11
    (11, 2, 100, '2021-05-15', 49.99, 69.99),
    -- Game 12
    (12, 3, 80, '2019-09-20', 39.99, 59.99),
    -- Game 13
    (13, 1, 110, '2020-02-12', 44.99, 64.99),
    -- Game 14
    (14, 2, 70, '2021-08-28', 29.99, 49.99),
    -- Game 15
    (15, 3, 130, '2019-11-09', 49.99, 69.99),
    -- Game 16
    (16, 1, 90, '2020-06-17', 39.99, 59.99),
    -- Game 17
    (17, 2, 75, '2018-12-01', 59.99, 79.99),
    -- Game 18
    (18, 3, 105, '2019-03-24', 34.99, 54.99),
    -- Game 19
    (19, 1, 115, '2021-01-28', 49.99, 69.99),
    -- Game 20
    (20, 2, 125, '2019-06-09', 39.99, 59.99),
    -- Game 21
    (21, 3, 80, '2018-11-14', 44.99, 64.99),
    -- Game 22
    (22, 1, 95, '2021-04-05', 29.99, 49.99),
    -- Game 23
    (23, 2, 135, '2019-10-20', 49.99, 69.99),
    -- Game 24
    (24, 3, 100, '2020-02-01', 39.99, 59.99),
    -- Game 25
    (25, 1, 70, '2018-08-14', 59.99, 79.99),
    -- Game 26
    (26, 2, 95, '2020-11-22', 34.99, 54.99),
    -- Game 27
    (27, 3, 120, '2021-07-07', 49.99, 69.99),
    -- Game 28
    (28, 1, 110, '2019-12-30', 39.99, 59.99),
    -- Game 29
    (29, 2, 85, '2018-05-18', 44.99, 64.99),
    -- Game 30
    (30, 3, 65, '2020-03-15', 29.99, 49.99),
    -- Game 31
    (31, 1, 140, '2021-09-02', 49.99, 69.99),
    -- Game 32
    (32, 2, 105, '2020-10-11', 39.99, 59.99),
    -- Game 33
    (33, 3, 75, '2019-11-27', 59.99, 79.99),
    -- Game 34
    (34, 1, 95, '2018-04-08', 34.99, 54.99),
    -- Game 35
    (35, 2, 115, '2021-03-20', 49.99, 69.99),
    -- Game 36
    (36, 3, 80, '2020-08-10', 39.99, 59.99),
    -- Game 37
    (37, 1, 130, '2019-01-17', 44.99, 64.99),
    -- Game 38
    (38, 2, 90, '2020-05-28', 29.99, 49.99),
    -- Game 39
    (39, 3, 100, '2021-10-07', 49.99, 69.99),
    -- Game 40
    (40, 1, 70, '2019-07-03', 39.99, 59.99);
 

-- Insert into Customers table
INSERT INTO Customers (FirstName, LastName, EmailAddress)
VALUES
    ('John', 'Doe', 'john.doe@example.com'),
    ('Jane', 'Smith', 'jane.smith@example.com'),
    ('Michael', 'Johnson', 'michael.johnson@example.com'),
    ('Emily', 'Brown', 'emily.brown@example.com'),
    ('William', 'Davis', 'william.davis@example.com'),
    ('Olivia', 'Wilson', 'olivia.wilson@example.com'),
    ('James', 'Martinez', 'james.martinez@example.com'),
    ('Emma', 'Anderson', 'emma.anderson@example.com'),
    ('Daniel', 'Taylor', 'daniel.taylor@example.com'),
    ('Sophia', 'Thomas', 'sophia.thomas@example.com');

    -- Insert into Orders table
INSERT INTO Orders (CustomerId, OrderDate)
VALUES
    (1, '2024-02-09'),
    (2, '2024-02-09'),
    (3, '2024-02-08'),
    (4, '2024-02-08'),
    (5, '2024-02-07'),
    (6, '2024-02-07'),
    (7, '2024-02-06'),
    (8, '2024-02-06'),
    (9, '2024-02-05'),
    (10, '2024-02-05');

-- Insert into OrderLines table
INSERT INTO OrderLines (OrderId, GameRealId, Quantity)
VALUES
  (1, 1, 2),
(1, 3, 1),
(2, 2, 3),
(2, 4, 2),
(3, 5, 1),
(3, 7, 2),
(4, 6, 1),
(4, 8, 3),
(5, 9, 2),
(5, 11, 1),
(6, 10, 3),
(6, 12, 2),
(7, 13, 1),
(7, 15, 2),
(8, 14, 3),
(8, 16, 1),
(9, 17, 2),
(9, 19, 3),
(10, 18, 1),
(10, 20, 2),
(1, 21, 3),
(1, 23, 1),
(2, 22, 2),
(2, 24, 3),
(9, 25, 1),
(8, 27, 2),
(4, 26, 3),
(6, 28, 1),
(1, 29, 2),
(3, 31, 3),
(3, 30, 1),
(1, 32, 2),
(7, 33, 3),
(7, 35, 1),
(8, 34, 2),
(8, 36, 3),
(9, 37, 1),
(1, 38, 3),
(6, 22, 1),
(4, 34, 2),
(3, 26, 3),
(2, 14, 1),
(3, 8, 3),
(3, 2, 1),
(4, 7, 2),
(9, 1, 3),
(9, 39, 1),
(9, 5, 2)

    
    -- Insert into Ratings table
INSERT INTO Ratings (GameId)
VALUES
    (1),
    (2),
    (3),
    (4),
    (5),
    (6),
    (7),
    (8),
    (9),
    (10);

    -- Insert into UserReviews table
INSERT INTO UserReviews (RatingId, CustomerId, ReviewDate, Score, ReviewText)
VALUES
    (1, 1, '2024-02-09', 4, 'Great game, highly recommended!'),
    (1, 2, '2024-02-09', 3, 'Decent game, could be better.'),
    (1, 3, '2024-02-08', 5, 'Fantastic game, exceeded expectations!'),
    (1, 4, '2024-02-08', 4, 'Enjoyable game, worth playing.'),
    (1, 5, '2024-02-07', 4, 'Solid game, lots of fun.'),
    (1, 6, '2024-02-07', 2, 'Disappointing game, not worth the hype.'),
    (1, 7, '2024-02-06', 5, 'Amazing game, couldn''t put it down!'),
    (1, 8, '2024-02-06', 4, 'Good game, enjoyed it.'),
    (1, 9, '2024-02-05', 3, 'Average game, nothing special.'),
    (1, 10, '2024-02-05', 5, 'Incredible game, must-play!'),
    (2, 1, '2024-02-04', 4, 'Really enjoyed this one, worth the price.'),
    (2, 2, '2024-02-04', 3, 'Not bad, but could have been better.'),
    (2, 3, '2024-02-03', 5, 'Absolutely loved it, worth every penny!'),
    (2, 4, '2024-02-03', 4, 'Solid game, would recommend.'),
    (2, 5, '2024-02-02', 4, 'Great gameplay, highly addictive.'),
    (3, 6, '2024-02-02', 2, 'Disappointing, didn''t live up to expectations.'),
    (3, 7, '2024-02-01', 5, 'One of the best games I''ve played!'),
    (3, 8, '2024-02-01', 4, 'Enjoyable experience, would play again.'),
    (3, 9, '2024-01-31', 3, 'Decent game, but lacked depth.'),
    (4, 10, '2024-01-31', 5, 'Absolutely fantastic, couldn''t get enough!'),
    (4, 1, '2024-01-30', 4, 'Impressed by the graphics and gameplay.'),
    (4, 2, '2024-01-30', 3, 'Fairly good, but nothing exceptional.'),
    (4, 3, '2024-01-29', 5, 'A masterpiece, worth every minute of playtime!'),
    (7, 4, '2024-01-29', 4, 'Solid game, enjoyable experience.'),
    (7, 5, '2024-01-28', 4, 'Fun and immersive, highly recommended.');





   

