DECLARE @CustomerID INT;
DECLARE @TotalSpent DECIMAL(10, 2);
DECLARE @PointsEarned INT;
declare @CurrentYear INT = YEAR(GETDATE());

SET @CustomerID = -1;

SELECT @TotalSpent = SUM(Amount)
FROM Purchases
WHERE CustomerID = @CustomerID AND YEAR(PurchaseDate) = @CurrentYear;

SET @PointsEarned = CAST(@TotalSpent / 10 AS INT);

UPDATE Customers
SET LoyaltyPoints = LoyaltyPoints + @PointsEarned
WHERE CustomerID = @CustomerID;

PRINT 'Loyalty Points Update for Customer ID: ' + CAST(@CustomerID AS VARCHAR);
PRINT 'Total Amount Spent in ' + CAST(@CurrentYear AS VARCHAR) + ': $' + CAST(@TotalSpent AS VARCHAR);
PRINT 'Loyalty Points Earned: ' + CAST(@PointsEarned AS VARCHAR);