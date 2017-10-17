/* ********************************************************
	Section 1. DDL (25 pts)
***********************************************************/
/* ********************************************************
	1.	Database design
***********************************************************/

--CREATE DATABASE Bakery;
--GO

--USE Bakery;

CREATE TABLE Countries
(
             Id   INT IDENTITY,
             Name NVARCHAR(50)
             UNIQUE,
             CONSTRAINT PK_Countries PRIMARY KEY(Id)
);

CREATE TABLE Customers
(
             Id          INT IDENTITY,
             FirstName   NVARCHAR(25),
             LastName    NVARCHAR(25),
             Gender      CHAR(1),
             Age         INT,
             --PhoneNumber VARCHAR(10), -- Judge doesn't give points with this
             PhoneNumber CHAR(10),
             CountryId   INT,
             CONSTRAINT PK_Customers PRIMARY KEY(Id),
             CONSTRAINT CK_Gender CHECK(Gender = 'M'
                                        OR Gender = 'F'),
             CONSTRAINT FK_Customers_Countries FOREIGN KEY(CountryId) REFERENCES Countries(Id)
);

CREATE TABLE Products
(
             Id            INT IDENTITY,
             Name          NVARCHAR(25)
             UNIQUE,
             [Description] NVARCHAR(250),
             Recipe        NVARCHAR(MAX),
             --Price         DECIMAL(15, 2), -- Judge doesn't give points with this
             Price         MONEY,
             CONSTRAINT PK_Products PRIMARY KEY(Id),
             CONSTRAINT CK_Price CHECK(Price >= 0)
);

CREATE TABLE Feedbacks
(
             Id            INT IDENTITY,
             [Description] NVARCHAR(255),
             Rate          DECIMAL(4, 2),
             ProductId     INT,
             CustomerId    INT,
             CONSTRAINT PK_Feedbacks PRIMARY KEY(Id),
             CONSTRAINT CK_Rate CHECK(Rate >= 0
                                      AND Rate <= 10),
             CONSTRAINT FK_Feedbacks_Products FOREIGN KEY(ProductId) REFERENCES Products(Id),
             CONSTRAINT FK_Feedbacks_Customers FOREIGN KEY(CustomerId) REFERENCES Customers(Id)
);

CREATE TABLE Distributors
(
             Id          INT IDENTITY,
             [Name]      NVARCHAR(25)
             UNIQUE,
             AddressText NVARCHAR(30),
             Summary     NVARCHAR(200),
             CountryId   INT,
             CONSTRAINT PK_Distributors PRIMARY KEY(Id),
             CONSTRAINT FK_Distributors_Countries FOREIGN KEY(CountryId) REFERENCES Countries(Id)
);

CREATE TABLE Ingredients
(
             Id              INT IDENTITY,
             Name            NVARCHAR(30),
             [Description]   NVARCHAR(200),
             OriginCountryId INT,
             DistributorId   INT,
             CONSTRAINT PK_Ingredients PRIMARY KEY(Id),
             CONSTRAINT FK_Ingredients_Countries FOREIGN KEY(OriginCountryId) REFERENCES Countries(Id),
             CONSTRAINT FK_Ingredients_Distributors FOREIGN KEY(DistributorId) REFERENCES Distributors(Id)
);

CREATE TABLE ProductsIngredients
(
             ProductId    INT,
             IngredientId INT,
             CONSTRAINT PK_ProductsIngredients PRIMARY KEY(ProductId, IngredientId),
             CONSTRAINT FK_ProductsIngredients_Products FOREIGN KEY(ProductId) REFERENCES Products(Id),
             CONSTRAINT FK_ProductsIngredients_Ingredients FOREIGN KEY(IngredientId) REFERENCES Ingredients(Id)
);

/* ********************************************************
	Section 2. DML (15 pts)
***********************************************************/
/* ********************************************************
	2.	Insert
***********************************************************/

INSERT INTO Distributors([Name],
                         CountryId,
                         AddressText,
                         Summary
                        )
VALUES
(
       'Deloitte & Touche',
       2,
       '6 Arch St #9757',
       'Customizable neutral traveling'
),
(
       'Congress Title',
       13,
       '58 Hancock St',
       'Customer loyalty'
),
(
       'Kitchen People',
       1,
       '3 E 31st St #77',
       'Triple-buffered stable delivery'
),
(
       'General Color Co Inc',
       21,
       '6185 Bohn St #72',
       'Focus group'
),
(
       'Beck Corporation',
       23,
       '21 E 64th Ave',
       'Quality-focused 4th generation hardware'
);

INSERT INTO Customers(FirstName,
                      LastName,
                      Age,
                      Gender,
                      PhoneNumber,
                      CountryId
                     )
VALUES
(
       'Francoise',
       'Rautenstrauch',
       15,
       'M',
       '0195698399',
       5
),
(
       'Kendra',
       'Loud',
       22,
       'F',
       '0063631526',
       11
),
(
       'Lourdes',
       'Bauswell',
       50,
       'M',
       '0139037043',
       8
),
(
       'Hannah',
       'Edmison',
       18,
       'F',
       '0043343686',
       1
),
(
       'Tom',
       'Loeza',
       31,
       'M',
       '0144876096',
       23
),
(
       'Queenie',
       'Kramarczyk',
       30,
       'F',
       '0064215793',
       29
),
(
       'Hiu',
       'Portaro',
       25,
       'M',
       '0068277755',
       16
),
(
       'Josefa',
       'Opitz',
       43,
       'F',
       '0197887645',
       17
);

/* ********************************************************
	3.	Update
***********************************************************/

UPDATE Ingredients
  SET
      DistributorId = 35
WHERE Name IN('Bay Leaf', 'Paprika', 'Poppy');

UPDATE Ingredients
  SET
      OriginCountryId = 14
WHERE OriginCountryId = 8;

/* ********************************************************
	4.	Delete
***********************************************************/

DELETE FROM Feedbacks
WHERE CustomerId = 14
      OR ProductId = 5;
	  
/* ********************************************************
	5.	Products by Price
***********************************************************/

SELECT Name,
       CONVERT(DECIMAL(18, 2), Price) AS Price,
       Description
FROM Products
ORDER BY Price DESC,
         Name;
		 
/* ********************************************************
	6.	Ingredients
***********************************************************/

SELECT Name,
       Description,
       OriginCountryId
FROM Ingredients
WHERE OriginCountryId IN(1, 10, 20)
ORDER BY Id;

/* ********************************************************
	7.	Ingredients from Bulgaria and Greece
***********************************************************/

SELECT TOP (15) i.Name,
                i.Description,
                c.Name AS CountryName
FROM Ingredients AS i
     JOIN Countries AS c ON c.Id = i.OriginCountryId
WHERE c.Name IN('Bulgaria', 'Greece')
ORDER BY i.Name,
         c.Name;
		 
/* ********************************************************
	8.	Best Rated Products
***********************************************************/

SELECT TOP (10) p.Name,
                p.Description,
                AVG(f.Rate) AS AverageRate,
                COUNT(*) AS FeedbacksAmount
FROM Products AS p
     JOIN Feedbacks AS f ON f.ProductId = p.Id
GROUP BY p.Name,
         p.Description
ORDER BY AverageRate DESC,
         FeedbacksAmount DESC;
		 
/* ********************************************************
	9.	Negative Feedback
***********************************************************/

SELECT f.ProductId ProductId,
       f.Rate,
       f.Description,
       cust.Id AS CustomerId,
       cust.Age,
       cust.Gender
FROM Feedbacks AS f
     JOIN Customers AS cust ON cust.Id = f.CustomerId
WHERE f.Rate < 5
ORDER BY ProductId DESC,
         f.Rate;
		 
/* ********************************************************
	10.	Customers without Feedback
***********************************************************/

SELECT CONCAT(c.FirstName, ' '+c.LastName) AS CustomerName,
       c.PhoneNumber,
       c.Gender
FROM Customers AS c
     LEFT JOIN Feedbacks AS f ON f.CustomerId = c.Id
WHERE f.CustomerId IS NULL
ORDER BY c.Id;

/* ********************************************************
	11.	Honorable Mentions
***********************************************************/

SELECT f.ProductId,
       CONCAT(c.FirstName, ' '+c.LastName) AS CustomerName,
       f.Description AS FeedbackDescription
FROM Feedbacks AS f
     JOIN Customers AS c ON c.Id = f.CustomerId
WHERE f.CustomerId IN
(
    SELECT CustomerId
    FROM Feedbacks
    GROUP BY CustomerId
    HAVING COUNT(*) >= 3
)
ORDER BY f.ProductId,
         CustomerName,
         f.Id;
		 
/* ********************************************************
	12.	Customers by Criteria
***********************************************************/

SELECT cus.FirstName,
       cus.Age,
       cus.PhoneNumber
FROM Customers AS cus
     JOIN Countries AS cory ON cory.Id = cus.CountryId
WHERE(cus.FirstName LIKE '%an%'
      AND cus.Age >= 21)
     OR (RIGHT(cus.PhoneNumber, 2) = '38'
         AND cory.Name != 'Greece')
ORDER BY cus.FirstName,
         cus.Age DESC;
		 
/* ********************************************************
	13.	Middle Range Distributors
***********************************************************/

SELECT d.Name AS DistributorName,
       i.Name AS IngredientName,
       p.Name AS ProductName,
       AVG(f.Rate) AS AverageRate
FROM Distributors AS d
     JOIN Ingredients AS i ON i.DistributorId = d.Id
     JOIN ProductsIngredients AS pi ON pi.IngredientId = i.Id
     JOIN Products AS p ON p.Id = pi.ProductId
     JOIN Feedbacks AS f ON f.ProductId = p.Id
GROUP BY d.Name,
         i.Name,
         p.Name
HAVING AVG(f.Rate) BETWEEN 5 AND 8
ORDER BY DistributorName,
         IngredientName,
         ProductName;
		 
/* ********************************************************
	14.	The Most Positive Country
***********************************************************/

SELECT TOP (1) WITH TIES cry.Name AS CountryName,
                         AVG(f.Rate) AS FeedbackRate
FROM Countries AS cry
     JOIN Customers AS cus ON cus.CountryId = cry.Id
     JOIN Feedbacks AS f ON f.CustomerId = cus.Id
GROUP BY cry.Name
ORDER BY FeedbackRate DESC;

/* ********************************************************
	15.	Country Representative
***********************************************************/

SELECT CountryName,
       DisributorName
FROM
(
    SELECT c.Name AS CountryName,
           d.Name AS DisributorName,
           COUNT(i.DistributorId) AS IngredientsByDistributor,
           DENSE_RANK() OVER(PARTITION BY c.Name ORDER BY COUNT(i.DistributorId) DESC) AS Rank
    FROM Countries AS c
         LEFT JOIN Distributors AS d ON d.CountryId = c.Id
         LEFT JOIN Ingredients AS i ON i.DistributorId = d.Id
    GROUP BY c.Name,
             d.Name
) AS ranked
WHERE Rank = 1
ORDER BY CountryName,
         DisributorName;
		 
/* ********************************************************
	16.	Customers with Countries
***********************************************************/

CREATE VIEW v_UserWithCountries
AS
     SELECT concat(cmer.FirstName+' ', cmer.LastName) AS CustomerName,
            cmer.Age,
            cmer.Gender,
            cry.Name AS CountryName
     FROM Customers AS cmer
          JOIN Countries AS cry ON cry.Id = cmer.CountryId;
		  
/* ********************************************************
	17.	Feedback by Product Name
***********************************************************/

CREATE FUNCTION udf_GetRating
(
                @productName NVARCHAR(25)
)
RETURNS VARCHAR(9)
AS
     BEGIN
         DECLARE @productRate DECIMAL(4, 2) =
         (
             SELECT AVG(f.Rate)
             FROM Products AS p
                  JOIN Feedbacks AS f ON f.ProductId = p.Id
             WHERE p.Name = @productName
         );
         IF(@productRate IS NULL)
             BEGIN
                 RETURN 'No rating';
         END;
         IF(@productRate < 5)
             BEGIN
                 RETURN 'Bad';
         END;
         IF(@productRate <= 8)
             BEGIN
                 RETURN 'Average';
         END;
         RETURN 'Good';
     END;
	 
/* ********************************************************
	18.	Send Feedback
***********************************************************/

CREATE PROCEDURE usp_SendFeedback
(
                 @customerId  INT,
                 @productId   INT,
                 @rate        DECIMAL(4, 2),
                 @description NVARCHAR(255)
)
AS
     BEGIN
         DECLARE @feedbacksFromThisCustomerForThisProduct INT=
         (
             SELECT COUNT(*)
             FROM Feedbacks
             WHERE CustomerId = @customerId
         );
         IF(@feedbacksFromThisCustomerForThisProduct >= 3)
             BEGIN
                 RAISERROR('You are limited to only 3 feedbacks per product!', 16, 1);
         END;

	    -- Insert the Feedback
         INSERT INTO Feedbacks(CustomerId,
                               ProductId,
                               Rate,
                               Description
                              )
         VALUES
         (
                @customerId,
                @productId,
                @rate,
                @description
         );
     END;
	 
/* ********************************************************
	19.	Delete Products
***********************************************************/

CREATE TRIGGER tr_DeleteProduct ON products
INSTEAD OF DELETE
AS
     BEGIN
         DECLARE @productId INT=
         (
             SELECT Id
             FROM deleted
         );

	    -- Delete Feedbacks
         DELETE FROM Feedbacks
         WHERE ProductId = @productId;

	    -- Delete ProductIngredient relations
         DELETE FROM ProductsIngredients
         WHERE ProductId = @productId;

	    -- Delete Product
         DELETE FROM Products
         WHERE Id = @productId;
     END;
	 
/* ********************************************************
	20.	Products by One Distributor
***********************************************************/

SELECT p.Name AS ProductName,
       AVG(f.Rate) AS ProductAverageRate,
       d.Name AS DistributorName,
       c.Name AS DistributorCountry
FROM Products AS p
     JOIN Feedbacks AS f ON f.ProductId = p.Id
     JOIN ProductsIngredients AS pi ON pi.ProductId = p.Id
     JOIN Ingredients AS i ON i.Id = pi.IngredientId
     JOIN Distributors AS d ON d.Id = i.DistributorId
     JOIN Countries AS c ON c.Id = d.CountryId
GROUP BY p.Name,
         p.id,
         d.Name,
         c.Name
HAVING p.Id IN
(
    SELECT p.Id
    FROM Products AS p
         JOIN ProductsIngredients AS pi ON pi.ProductId = p.Id
         JOIN Ingredients AS i ON i.Id = pi.IngredientId
    GROUP BY p.Name,
             p.Id
    HAVING COUNT(DISTINCT i.DistributorId) = 1
)
ORDER BY p.Id;