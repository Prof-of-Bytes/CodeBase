CREATE TABLE [dbo].[Genres] (
    [GenreId]     INT            IDENTITY (1, 1) NOT NULL,
    [GenreName]   NVARCHAR (100) NOT NULL,
    [Description] NVARCHAR (250) NOT NULL,
    CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED ([GenreId] ASC)
);

CREATE TABLE [dbo].[Publishers] (
    [PublisherId]   INT            IDENTITY (1, 1) NOT NULL,
    [PublisherName] NVARCHAR (50)  NOT NULL,
    [PublisherURL]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Publishers] PRIMARY KEY CLUSTERED ([PublisherId] ASC)
);

CREATE TABLE [dbo].[Platforms] (
    [PlatformId]   INT           IDENTITY (1, 1) NOT NULL,
    [PlatformName] NVARCHAR (50) NOT NULL,
    [Manufacturer] INT           NOT NULL,
    CONSTRAINT [PK_Platforms] PRIMARY KEY CLUSTERED ([PlatformId] ASC)
);

CREATE TABLE [dbo].[Games] (
    [GameId]      INT            IDENTITY (1, 1) NOT NULL,
    [GenreId]     INT            NOT NULL,
    [PublisherId] INT            NOT NULL,
    [Title]       NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED ([GameId] ASC),
    CONSTRAINT [FK_Games_Genres_GenreId] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genres] ([GenreId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Games_Publishers_PublisherId] FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publishers] ([PublisherId]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Customers] (
    [CustomerId]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]    NVARCHAR (50)  NOT NULL,
    [LastName]     NVARCHAR (50)  NOT NULL,
    [EmailAddress] NVARCHAR (MAX) NOT NULL,
    [UserIdentity] NVARCHAR (450) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

CREATE TABLE [dbo].[GamesReal] (
    [GameRealId]    INT            IDENTITY (1, 1) NOT NULL,
    [GameId]        INT            NOT NULL,
    [PlatformId]    INT            NOT NULL,
    [Quantity]      INT            NOT NULL,
    [ReleaseDate]   DATETIME2 (7)  NOT NULL,
    [PurchasePrice] DECIMAL (6, 2) NOT NULL,
    [SalePrice]     DECIMAL (6, 2) NOT NULL,
    CONSTRAINT [PK_GamesReal] PRIMARY KEY CLUSTERED ([GameRealId] ASC),
    CONSTRAINT [FK_GamesReal_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Games] ([GameId]) ON DELETE CASCADE,
    CONSTRAINT [FK_GamesReal_Platforms_PlatformId] FOREIGN KEY ([PlatformId]) REFERENCES [dbo].[Platforms] ([PlatformId]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Orders] (
    [OrderId]    INT             IDENTITY (1, 1) NOT NULL,
    [CustomerId] INT             NOT NULL,
    [OrderDate]  DATETIME2 (7)   NOT NULL,
    [Total]      DECIMAL (10, 2) NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[OrderLines] (
    [OrderId]    INT            NOT NULL,
    [GameRealId] INT            NOT NULL,
    [Quantity]   INT            NOT NULL,
    [SubTotal]   DECIMAL (6, 2) NOT NULL,
    CONSTRAINT [PK_OrderLines] PRIMARY KEY CLUSTERED ([OrderId] ASC, [GameRealId] ASC),
    CONSTRAINT [FK_OrderLines_GamesReal_GameRealId] FOREIGN KEY ([GameRealId]) REFERENCES [dbo].[GamesReal] ([GameRealId]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderLines_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Ratings] (
    [RatingId]      INT  IDENTITY (1, 1) NOT NULL,
    [GameId]        INT  NOT NULL,
    [OverallRating] REAL NOT NULL,
    CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED ([RatingId] ASC),
    CONSTRAINT [FK_Ratings_Games_GameId] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Games] ([GameId]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[UserReviews] (
    [RatingId]   INT            NOT NULL,
    [CustomerId] INT            NOT NULL,
    [ReviewDate] DATETIME2 (7)  NOT NULL,
    [Score]      INT            NOT NULL,
    [ReviewText] NVARCHAR (500) NOT NULL,
    CONSTRAINT [PK_UserReviews] PRIMARY KEY CLUSTERED ([RatingId] ASC, [CustomerId] ASC),
    CONSTRAINT [FK_UserReviews_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([CustomerId]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserReviews_Ratings_RatingId] FOREIGN KEY ([RatingId]) REFERENCES [dbo].[Ratings] ([RatingId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserReviews_CustomerId]
    ON [dbo].[UserReviews]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId]
    ON [dbo].[Orders]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_GamesReal_GameId]
    ON [dbo].[GamesReal]([GameId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_GamesReal_PlatformId]
    ON [dbo].[GamesReal]([PlatformId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Games_GenreId]
    ON [dbo].[Games]([GenreId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Games_PublisherId]
    ON [dbo].[Games]([PublisherId] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_OrderLines_GameRealId]
    ON [dbo].[OrderLines]([GameRealId] ASC);
	
GO
CREATE NONCLUSTERED INDEX [IX_Ratings_GameId]
    ON [dbo].[Ratings]([GameId] ASC);
