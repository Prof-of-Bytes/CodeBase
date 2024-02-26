CREATE OR ALTER TRIGGER Update_OrderLines_SubTotal
ON OrderLines
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ol
    SET SubTotal = ol.Quantity * gr.SalePrice
    FROM OrderLines ol
    JOIN Orders o ON ol.OrderId = o.OrderId
    JOIN GamesReal gr ON ol.GameRealId = gr.GameRealId;
END;
