/* ********************************************************
	1.	Database design
***********************************************************/

/* Not for Judge
CREATE DATABASE WMS;
GO

USE WMS;
*/

CREATE TABLE Clients
(
             ClientId  INT NOT NULL PRIMARY KEY IDENTITY,
             FirstName VARCHAR(50) NOT NULL,
             LastName  VARCHAR(50) NOT NULL,
             Phone     CHAR(12) NOT NULL
);

CREATE TABLE Mechanics
(
             MechanicId INT NOT NULL PRIMARY KEY IDENTITY,
             FirstName  VARCHAR(50) NOT NULL,
             LastName   VARCHAR(50) NOT NULL,
             Address    VARCHAR(255) NOT NULL
);

CREATE TABLE Models
(
             ModelId INT NOT NULL PRIMARY KEY IDENTITY,
             Name    VARCHAR(50)
             UNIQUE NOT NULL
);

CREATE TABLE Jobs
(
             JobId      INT NOT NULL PRIMARY KEY IDENTITY,
             ModelId    INT NOT NULL
                            FOREIGN KEY REFERENCES Models(ModelId),
             Status     VARCHAR(11) NOT NULL
                                    DEFAULT 'Pending'
                                    CHECK(status IN('Pending', 'In Progress', 'Finished')),
             ClientId   INT NOT NULL
                            FOREIGN KEY REFERENCES Clients(ClientId),
             MechanicId INT NULL
                            FOREIGN KEY REFERENCES Mechanics(MechanicId),
             IssueDate  DATETIME2 NOT NULL,
             FinishDate DATETIME2
);

CREATE TABLE Orders
(
             OrderId   INT NOT NULL PRIMARY KEY IDENTITY,
             JobId     INT NOT NULL
                           FOREIGN KEY REFERENCES Jobs(JobId),
             IssueDate DATETIME2,
             Delivered BIT NOT NULL
                           DEFAULT 0
);

CREATE TABLE Vendors
(
             VendorId INT NOT NULL PRIMARY KEY IDENTITY,
             Name     VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Parts
(
             PartId       INT NOT NULL PRIMARY KEY IDENTITY,
             SerialNumber VARCHAR(50) NOT NULL UNIQUE,
             Description  VARCHAR(255),
             Price        DECIMAL(6, 2) NOT NULL
                                        CHECK(Price > 0),
             VendorId     INT NOT NULL
                              FOREIGN KEY REFERENCES Vendors(VendorId),
             StockQty     INT NOT NULL
                              DEFAULT 0
                              CHECK(StockQty >= 0)
);

CREATE TABLE OrderParts
(
             OrderId  INT NOT NULL
                          FOREIGN KEY REFERENCES Orders(OrderId),
             PartId   INT NOT NULL
                          FOREIGN KEY REFERENCES Parts(PartId),
             Quantity INT NOT NULL
                          DEFAULT 1
                          CHECK(Quantity > 0),
             CONSTRAINT PK_OrderParts PRIMARY KEY(OrderId, PartId)
);

CREATE TABLE PartsNeeded
(
             JobId    INT NOT NULL
                          FOREIGN KEY REFERENCES Jobs(JobId),
             PartId   INT NOT NULL
                          FOREIGN KEY REFERENCES Parts(PartId),
             Quantity INT NOT NULL
                          DEFAULT 1
                          CHECK(Quantity > 0),
             CONSTRAINT PK_PartsNeeded PRIMARY KEY(JobId, PartId)
);

/* ********************************************************
	2.	Insert
***********************************************************/

INSERT INTO Clients(FirstName,
                    LastName,
                    Phone
                   )
VALUES
(
       'Teri',
       'Ennaco',
       '570-889-5187'
),
(
       'Merlyn',
       'Lawler',
       '201-588-7810'
),
(
       'Georgene',
       'Montezuma',
       '925-615-5185'
),
(
       'Jettie',
       'Mconnell',
       '908-802-3564'
),
(
       'Lemuel',
       'Latzke',
       '631-748-6479'
),
(
       'Melodie',
       'Knipp',
       '805-690-1682'
),
(
       'Candida',
       'Corbley',
       '908-275-8357'
);

INSERT INTO Parts(SerialNumber,
                  Description,
                  Price,
                  VendorId
                 )
VALUES
(
       'WP8182119',
       'Door Boot Seal',
       117.86,
	  (
	      SELECT TOP (1) VendorId
	      FROM Vendors
	      WHERE Name = 'Suzhou Precision Products'
	  )
),
(
       'W10780048',
       'Suspension Rod',
       42.81,
	  (
	      SELECT TOP (1) VendorId
	      FROM Vendors
	      WHERE Name = 'Shenzhen Ltd.'
	  )
),
(
       'W10841140',
       'Silicone Adhesive',
       6.77,
	  (
	      SELECT TOP (1) VendorId
	      FROM Vendors
	      WHERE Name = 'Fenghua Import Export'
	  )
),
(
       'WPY055980',
       'High Temperature Adhesive',
       13.94,
	  (
	      SELECT TOP (1) VendorId
	      FROM Vendors
	      WHERE Name = 'Qingdao Technology'
	  )
);

/* ********************************************************
	3.	Update
***********************************************************/

UPDATE Jobs
  SET
      Status = 'In Progress',
      MechanicId =
(
    SELECT TOP (1) MechanicId
    FROM Mechanics
    WHERE FirstName + ' ' + LastName = 'Ryan Harnos'
)
WHERE Status = 'Pending';

/* ********************************************************
	4.	Delete
***********************************************************/

DELETE FROM OrderParts
WHERE OrderId = 19;

DELETE FROM Orders
WHERE OrderId = 19;

/* ********************************************************
	5.	Clients by Name
***********************************************************/

SELECT FirstName,
       LastName,
       Phone
FROM Clients
ORDER BY LastName,
         ClientId;

/* ********************************************************
	6.	Job Status
***********************************************************/

SELECT Status,
       IssueDate
FROM Jobs
WHERE FinishDate IS NULL
ORDER BY IssueDate,
         JobId;

/* ********************************************************
	7.	Mechanic Assignments
***********************************************************/

SELECT concat(m.FirstName + ' ', m.LastName) AS Mechanic,
       j.Status,
       j.IssueDate
FROM Mechanics AS m
     JOIN Jobs AS j ON j.MechanicId = m.MechanicId
ORDER BY m.MechanicId,
         IssueDate,
         j.JobId;

/* ********************************************************
	8.	Current Clients
***********************************************************/

SELECT CONCAT(c.FirstName, ' ' + c.LastName) AS Client,
       DATEDIFF(DAY, IssueDate, '24 April 2017') AS [Days going],
       j.Status
FROM Clients AS c
     JOIN Jobs AS j ON j.ClientId = c.ClientId
WHERE j.Status != 'Finished'
ORDER BY [Days going] DESC,
         c.ClientId;

/* ********************************************************
	9.	Mechanic Performance
***********************************************************/

SELECT CONCAT(m.FirstName, ' ' + m.LastName) AS Mechanic,
       CEILING(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))) AS [Average Days]
FROM Mechanics AS m
     JOIN Jobs AS j ON j.MechanicId = m.MechanicId
GROUP BY CONCAT(m.FirstName, ' '+m.LastName),
         m.MechanicId
ORDER BY m.MechanicId;

/* ********************************************************
	10.	Hard Earners
***********************************************************/

SELECT TOP (3) WITH TIES CONCAT(m.FirstName, ' ' + m.LastName) AS Mechanic,
                         COUNT(j.JobId) AS Jobs
FROM Mechanics AS m
     JOIN Jobs AS j ON j.MechanicId = m.MechanicId
WHERE j.Status != 'Finished'
GROUP BY m.MechanicId,
         CONCAT(m.FirstName, ' '+m.LastName)
HAVING COUNT(j.JobId) > 1
ORDER BY Jobs DESC,
         m.MechanicId;

/* ********************************************************
	11.	Available Mechanics
***********************************************************/

SELECT CONCAT(FirstName, ' ' + LastName) AS Available
FROM Mechanics
WHERE MechanicId NOT IN
(
    SELECT DISTINCT
           m.MechanicId
    FROM Mechanics AS m
         JOIN Jobs AS j ON j.MechanicId = m.MechanicId
    WHERE j.Status = 'In Progress'
)
ORDER BY MechanicId;

/* ********************************************************
	12.	Parts Cost
***********************************************************/

SELECT ISNULL(SUM(Price * Quantity), 0) AS [Parts Total]
FROM
(
    SELECT p.Price,
           op.Quantity,
		   DATEDIFF(WEEK, o.IssueDate, '24 April 2017') AS Weeks
    FROM Parts AS p
         JOIN OrderParts AS op ON op.PartId = p.PartId
         JOIN Orders AS o ON o.OrderId = op.OrderId
) AS WeeksAndPrices
WHERE Weeks <= 3;

/* ********************************************************
	13.	Past Expenses
***********************************************************/

SELECT j.JobId,
       ISNULL(SUM(p.Price * op.Quantity), 0.00) AS Total
FROM Jobs AS j
     LEFT JOIN Orders AS o ON o.JobId = j.JobId
     LEFT JOIN OrderParts AS op ON op.OrderId = o.OrderId
     LEFT JOIN Parts AS p ON p.PartId = op.PartId
WHERE j.Status = 'Finished'
GROUP BY j.JobId
ORDER BY Total DESC,
         j.JobId;

/* ********************************************************
	14.	Model Repair Time
***********************************************************/

SELECT m.ModelId,
       m.Name,
       CONCAT(CEILING(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate))), ' days') AS [Average Service Time]
FROM Models AS m
     JOIN Jobs AS j ON j.ModelId = m.ModelId
WHERE j.FinishDate IS NOT NULL
GROUP BY m.ModelId,
         m.Name
ORDER BY CEILING(AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)));

/* ********************************************************
	15.	Faultiest Model
***********************************************************/

SELECT TOP (1) WITH TIES m.Name AS Model,
                         COUNT(*) AS [Times Serviced],
				     (
				         SELECT ISNULL(SUM(p.Price * op.Quantity), 0) AS [Parts Total]
				         FROM Parts AS p
				              JOIN OrderParts AS op ON op.PartId = p.PartId
				              JOIN Orders AS o ON o.OrderId = op.OrderId
				              JOIN Jobs AS j ON j.JobId = o.JobId
				         WHERE j.ModelId = m.ModelId
				     ) AS [Parts Total]
FROM Models AS m
     JOIN Jobs AS j ON j.ModelId = m.ModelId
GROUP BY m.ModelId,
         m.Name
ORDER BY COUNT(*) DESC;

/* ********************************************************
	16.	Missing Parts
***********************************************************/

SELECT p.PartId,
       p.Description,
       ISNULL(pn.Quantity, 0) AS Required,
       ISNULL(p.StockQty, 0) AS [In Stock],
       ISNULL(CASE
                  WHEN o.Delivered = 0
                  THEN op.Quantity
                  ELSE 0
              END, 0) AS Ordered
FROM Parts AS p
     JOIN PartsNeeded AS pn ON pn.PartId = p.PartId
     LEFT JOIN OrderParts AS op ON op.PartId = p.PartId
     JOIN Jobs AS j ON j.JobId = pn.JobId
     LEFT JOIN Orders AS o ON o.JobId = j.JobId
WHERE pn.Quantity > ISNULL(p.StockQty + CASE
                                            WHEN o.Delivered = 0
                                            THEN op.Quantity
                                            ELSE 0
                                        END, 0)
      AND j.Status != 'Finished'
ORDER BY p.PartId;

/* ********************************************************
	17.	Cost of Order
***********************************************************/

CREATE FUNCTION udf_GetCost
(
                @jobId INT
)
RETURNS DECIMAL(6, 2)
AS
     BEGIN
         RETURN
         (
             SELECT ISNULL(SUM(p.Price), 0)
             FROM Parts AS p
                  JOIN OrderParts AS op ON op.PartId = p.PartId
                  JOIN Orders AS o ON o.OrderId = op.OrderId
             WHERE o.JobId = @jobId
         );
     END;

/* ********************************************************
	18.	Place Order
***********************************************************/

CREATE PROCEDURE usp_PlaceOrder
(
                 @jobId            INT,
                 @partSerialNumber VARCHAR(50),
                 @quantity         INT
)
AS
     BEGIN
	    -- Params validation
         IF(@quantity <= 0)
             BEGIN;
                 THROW 50012, 'Part quantity must be more than zero!', 1;
         END;
         IF(
           (
               SELECT JobId  
               FROM Jobs
               WHERE JobId = @jobId
           ) IS NULL)
             BEGIN;
                 THROW 50013, 'Job not found!', 1;
         END;
         IF(
           (
               SELECT Status
               FROM Jobs
               WHERE JobId = @jobId
           ) = 'Finished')
             BEGIN;
                 THROW 50011, 'This job is not active!', 1;
         END;
         IF(
           (
               SELECT SerialNumber
               FROM Parts
               WHERE SerialNumber = @partSerialNumber
           ) IS NULL)
             BEGIN;
                 THROW 50014, 'Part not found!', 1;
         END;

	    -- Create Order if not exists
         IF(
           (
               SELECT JobId
               FROM Orders
               WHERE JobId = @jobId
                     AND IssueDate IS NULL
           ) IS NULL)
             BEGIN
                 INSERT INTO Orders(JobId,
                                    IssueDate,
                                    Delivered
                                   )
                 VALUES
                 (
                        @jobId,
                        NULL,
                        0
                 );
         END;

	    -- Add part to order if not exists
         DECLARE @orderId INT=
         (
             SELECT TOP 1 OrderId
             FROM Orders
             WHERE JobId = @jobId
                   AND IssueDate IS NULL
         );
         DECLARE @partId INT=
         (
             SELECT PartId
             FROM Parts
             WHERE SerialNumber = @partSerialNumber
         );
         IF(
           (
               SELECT PartId
               FROM OrderParts
               WHERE PartId = @partId
                     AND OrderId = @orderId
           ) IS NULL)
             BEGIN
                 INSERT INTO OrderParts(OrderId,
                                        PartId,
                                        Quantity
                                       )
                 VALUES
                 (
                        @orderId,
                        @partId,
                        @quantity
                 );
         END;
	    -- Part exists in the order - Add quantity
             ELSE
             BEGIN
                 UPDATE OrderParts
                   SET
                       Quantity+=@quantity
                 WHERE PartId = @partId
                       AND OrderId = @orderId;
         END;
     END;

/* ********************************************************
	19.	Detect Delivery
***********************************************************/

CREATE TRIGGER te_UpdateStockQuantityUponDeliveryArrival ON Orders
AFTER UPDATE
AS
     BEGIN
         IF(
           (
               SELECT Delivered
               FROM deleted
           ) = 0
           AND
           (
               SELECT Delivered
               FROM inserted
           ) = 1)
             BEGIN
			 -- Extract order data
                 WITH cte_OrderDataFromOrderParts(OrderId,
                                                  PartId,
                                                  Quantity)
                      AS (
                      SELECT OrderId,
                             PartId,
                             SUM(Quantity) AS Quantity
                      FROM OrderParts
                      WHERE OrderId =
                      (
                          SELECT OrderId
                          FROM inserted
                      )
                      GROUP BY OrderId,
                               PartId)

				  -- Update StockQty
                      UPDATE Parts
                        SET
                            StockQty+=cte.Quantity
                      FROM cte_OrderDataFromOrderParts AS cte
                      WHERE Parts.PartId = cte.PartId;
         END;
     END;

/* ********************************************************
	20.	Vendor Preference
***********************************************************/

WITH cte_JoinedGroupedTables
     AS (
     SELECT m.MechanicId,
            v.VendorId,
            SUM(op.Quantity) AS PartsForMechanicByVendor
     FROM Mechanics AS m
          JOIN jobs AS j ON j.MechanicId = m.MechanicId
          JOIN Orders AS o ON o.JobId = j.JobId
          JOIN OrderParts AS op ON op.OrderId = o.OrderId
          JOIN Parts AS p ON p.PartId = op.PartId
          JOIN Vendors AS v ON v.VendorId = p.VendorId
     GROUP BY m.MechanicId,
              v.VendorId)

     SELECT CONCAT(m.FirstName, ' ', m.LastName) AS Mechanic,
            v.Name AS Vendor,
            cte.PartsForMechanicByVendor AS Parts,
            CONCAT(FLOOR(cte.PartsForMechanicByVendor * 1.0 /
                        (
                            SELECT SUM(PartsForMechanicByVendor)
                            FROM cte_JoinedGroupedTables
                            WHERE MechanicId = m.MechanicId
                        ) * 100), '%') AS Preference
     FROM cte_JoinedGroupedTables AS cte
          JOIN Mechanics AS m ON m.MechanicId = cte.MechanicId
          JOIN Vendors AS v ON v.VendorId = cte.VendorId
     ORDER BY Mechanic,
              Parts DESC,
              Vendor;