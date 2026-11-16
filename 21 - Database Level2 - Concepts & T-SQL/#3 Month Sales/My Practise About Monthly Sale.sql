DECLARE @Year INT;
DECLARE @Month INT;
DECLARE @TotalSales DECIMAL(10, 2);
DECLARE @TotalTransaction int;
DECLARE @AverageSale DECIMAL(10, 2);

SET @Year = 2023;
SET @Month = 6;

SELECT @TotalSales = SUM(SaleAmount)
FROM Sales
WHERE YEAR(SaleDate) = @Year AND MONTH(SaleDate) = @Month;

SELECT @Totaltransaction = COUNT(*)
FROM Sales
WHERE Year(SaleDate) = @Year AND MONTH(SaleDate) = @Month; 

SET @AverageSale = @TotalSales / @Totaltransaction;
PRINT 'Monthly Sales Summary Report';
PRINT 'Year : ' + CAST(@Year AS VARCHAR) + ', Month : ' + CAST(@Month AS VARCHAR);
PRINT 'TotalSales : ' + CAST(@TotalSales AS VARCHAR);
PRINT 'TotalTransaction : ' + CAST(@TotalTransaction AS VARCHAR);
PRINT 'AverageSale : ' + CAST(@AverageSale AS VARCHAR);
