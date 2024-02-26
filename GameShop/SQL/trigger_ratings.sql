CREATE OR ALTER TRIGGER Update_Rating_Overall
ON  UserReviews

AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF (SELECT COUNT(*) FROM inserted) > 0
    BEGIN
        UPDATE r
        SET OverallRating = (SELECT AVG(ur.Score) FROM UserReviews ur WHERE ur.RatingId = r.RatingId)
        FROM Ratings r
        JOIN inserted i ON r.RatingId = i.RatingId;
    END
    ELSE IF (SELECT COUNT(*) FROM deleted) > 0
    BEGIN
        UPDATE r
        SET OverallRating = (SELECT AVG(ur.Score) FROM UserReviews ur WHERE ur.RatingId = r.RatingId)
        FROM Ratings r
        JOIN deleted d ON r.RatingId = d.RatingId;
    END
END;