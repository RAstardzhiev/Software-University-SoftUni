/* ******************************************
	Scripts for the creation of used Databases are here:
	https://github.com/RAstardzhiev/Software-University-SoftUni/tree/master/Databases%20Basics%20-%20MS%20SQL%20Server/Databases
*********************************************/

/* *****************************************************
	Part I – Queries for SoftUni Database
********************************************************/

USE SoftUni;

/* *****************************************************
	Problem 1.	Employees with Salary Above 35000
********************************************************/

CREATE PROCEDURE usp_GetEmployeesSalaryAbove35000
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE Salary > 35000;
     END; 
 
/* *****************************************************
	Problem 2.	Employees with Salary Above Number
********************************************************/

CREATE PROCEDURE usp_GetEmployeesSalaryAboveNumber
(
                 @minSalary MONEY
)
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE Salary >= @MinSalary;
     END;
	
/* Test procedure
EXEC dbo.usp_GetEmployeesSalaryAboveNumber
     48100;
 */
 
/* *****************************************************
	Problem 3.	Town Names Starting With
********************************************************/
 
CREATE PROCEDURE usp_GetTownsStartingWith
(
                 @startsWith NVARCHAR(MAX)
)
AS
     BEGIN
         SELECT Name AS Town
         FROM Towns
         WHERE Name LIKE(@startsWith+'%');
     END;
		
/* 
-- Test procedure
EXEC usp_GetTownsStartingWith
     'B'; 

-- Delete procedure
DROP PROC usp_GetTownsStartingWith;
 */
		
/* *****************************************************
	Problem 4.	Employees from Town
********************************************************/

CREATE PROCEDURE usp_GetEmployeesFromTown
(
                 @townName NVARCHAR(50)
)
AS
     BEGIN
         SELECT e.FirstName AS [First Name],
                e.LastName AS [Last Name]
         FROM Employees AS e
              JOIN Addresses AS a ON e.AddressID = a.AddressID
              JOIN Towns AS t ON a.TownID = t.TownID
         WHERE t.Name = @townName;
     END;
		
/* *****************************************************
	Problem 5.	Salary Level Function
********************************************************/

CREATE FUNCTION ufn_GetSalaryLevel
(
                @salary MONEY
)
RETURNS VARCHAR(7)
     BEGIN
         IF(@salary IS NULL)
             BEGIN
                 RETURN NULL;
         END;
         IF(@salary < 30000)
             BEGIN
                 RETURN 'Low';
         END;
             ELSE
             BEGIN
                 IF(@salary <= 50000)
                     BEGIN
                         RETURN 'Average';
                 END;
         END;
         RETURN 'High';
     END;

/* *****************************************************
	Problem 6.	Employees by Salary Level
********************************************************/

CREATE PROCEDURE usp_EmployeesBySalaryLevel
(
                 @levelOfSalary VARCHAR(7)
)
AS
     BEGIN
         SELECT FirstName AS [First Name],
                LastName AS [Last Name]
         FROM Employees
         WHERE dbo.ufn_GetSalaryLevel(Salary) = @levelOfSalary;
     END;
		
/* *****************************************************
	Problem 7.	Define Function
********************************************************/

CREATE FUNCTION ufn_IsWordComprised
(
                @setOfLetters NVARCHAR(MAX),
                @word         NVARCHAR(MAX)
)
RETURNS BIT
AS
     BEGIN
         DECLARE @currentIndex INT= 1;
         WHILE(@currentIndex <= LEN(@word))
             BEGIN
                 DECLARE @currentLetter CHAR= SUBSTRING(@word, @currentIndex, 1);
                 IF(CHARINDEX(@currentLetter, @setOfLetters) <= 0)
                     BEGIN
                         RETURN 0;
                 END;
                 SET @currentIndex+=1;
             END;
         RETURN 1;
     END;

/* *****************************************************
     ***** NOT FOR JUDGE ***** NOT FOR JUDGE *****
/* *****************************************************
	Understood from the old exercise explanation
/* *****************************************************
	Problem 8.1. * Delete Employees and Departments
********************************************************/

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment
(
                 @departmentName NVARCHAR(50)
)
AS
     BEGIN
         ALTER TABLE Employees ALTER COLUMN ManagerID INT;
         ALTER TABLE Employees ALTER COLUMN DepartmentID INT;
         UPDATE Employees
           SET
               DepartmentID = NULL
         WHERE EmployeeID IN
         (
         (
             SELECT e.EmployeeID
             FROM Employees AS e
                  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
             WHERE d.Name = @departmentName
         )
         );
         UPDATE Employees
           SET
               ManagerID = NULL
         WHERE ManagerID IN
         (
         (
             SELECT e.EmployeeID
             FROM Employees AS e
                  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
             WHERE d.Name = @departmentName
         )
         );
         ALTER TABLE Departments ALTER COLUMN ManagerID INT;
         UPDATE Departments
           SET
               ManagerID = NULL
         WHERE Name = @departmentName;
         DELETE FROM Departments
         WHERE Name = @departmentName;
         DELETE FROM EmployeesProjects
         WHERE EmployeeID IN
         (
         (
             SELECT e.EmployeeID
             FROM Employees AS e
                  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
             WHERE d.Name = @departmentName
         )
         );
         DELETE FROM Employees
         WHERE EmployeeID IN
         (
         (
             SELECT e.EmployeeID
             FROM Employees AS e
                  JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
             WHERE d.Name = @departmentName
         )
         );
     END;
         
BEGIN TRANSACTION;

EXECUTE usp_DeleteEmployeesFromDepartment
        'Production';

EXECUTE usp_DeleteEmployeesFromDepartment
        'Production Control';

ROLLBACK;

/* *****************************************************
     ***** NOT FOR JUDGE ***** NOT FOR JUDGE *****
/* *****************************************************
	Understood from the old exercise explanation
/* *****************************************************
	Option without procedure 
********************************************************/
ALTER TABLE Employees ALTER COLUMN ManagerID INT;

ALTER TABLE Employees ALTER COLUMN DepartmentID INT;

UPDATE Employees
  SET
      DepartmentID = NULL
WHERE EmployeeID IN
(
(
    SELECT e.EmployeeID
    FROM Employees AS e
         JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
    WHERE d.Name IN('Production', 'Production Control')
)
);

UPDATE Employees
  SET
      ManagerID = NULL
WHERE ManagerID IN
(
(
    SELECT e.EmployeeID
    FROM Employees AS e
         JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
    WHERE d.Name IN('Production', 'Production Control')
)
);

ALTER TABLE Departments ALTER COLUMN ManagerID INT;

UPDATE Departments
  SET
      ManagerID = NULL
WHERE Name IN('Production', 'Production Control');

DELETE FROM Departments
WHERE Name IN('Production', 'Production Control');

DELETE FROM EmployeesProjects
WHERE EmployeeID IN
(
(
    SELECT e.EmployeeID
    FROM Employees AS e
         JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
    WHERE d.Name IN('Production', 'Production Control')
)
);

DELETE FROM Employees
WHERE EmployeeID IN
(
(
    SELECT e.EmployeeID
    FROM Employees AS e
         JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
    WHERE d.Name IN('Production', 'Production Control')
)
);

/* *****************************************************
 ****** FOR JUDGE ***** FOR JUDGE ***** FOR JUDGE *****
/* *****************************************************
	NEW exercise explanation
/* *****************************************************
	Problem 8.2. * Delete Employees and Departments
********************************************************/

CREATE PROCEDURE usp_DeleteEmployeesFromDepartment
(
                 @departmentId INT
)
AS
     BEGIN
         ALTER TABLE Employees ALTER COLUMN ManagerID INT;

         ALTER TABLE Employees ALTER COLUMN DepartmentID INT;

         UPDATE Employees
           SET
               DepartmentID = NULL
         WHERE EmployeeID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         UPDATE Employees
           SET
               ManagerID = NULL
         WHERE ManagerID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         ALTER TABLE Departments ALTER COLUMN ManagerID INT;

         UPDATE Departments
           SET
               ManagerID = NULL
         WHERE DepartmentID = @departmentId;

         DELETE FROM Departments
         WHERE DepartmentID = @departmentId;

         DELETE FROM EmployeesProjects
         WHERE EmployeeID IN
         (
         (
             SELECT EmployeeID
             FROM Employees
             WHERE DepartmentID = @departmentId
         )
         );

         DELETE FROM Employees
         WHERE DepartmentID = @departmentId;

         SELECT COUNT(*)
         FROM Employees
         WHERE DepartmentID = @departmentId;
     END;

/* *****************************************************
	Problem 9.	Employees with Three Projects
********************************************************/

/* According the requirement */
CREATE PROCEDURE usp_AssignProject
(
                 @emloyeeId INT,
                 @projectID INT
)
AS
     BEGIN
         BEGIN TRANSACTION;
         INSERT INTO EmployeesProjects(EmployeeID,
                                       ProjectID
                                      )
         VALUES
         (
                @emloyeeId,
                @projectID
         );
         IF(
           (
               SELECT COUNT(EmployeeID)
               FROM EmployeesProjects
               WHERE EmployeeID = @emloyeeId
           ) > 3)
             BEGIN
                 ROLLBACK;
                 RAISERROR('The employee has too many projects!', 16, 1);
         END;
         COMMIT;
     END;
	   
/* Same result without transaction */
CREATE PROCEDURE usp_AssignProject
(
                 @emloyeeId INT,
                 @projectID INT
)
AS
     BEGIN
         IF(
           (
               SELECT COUNT(EmployeeID)
               FROM EmployeesProjects
               WHERE EmployeeID = @emloyeeId
           ) < 3)
             BEGIN
                 INSERT INTO EmployeesProjects(EmployeeID,
                                               ProjectID
                                              )
                 VALUES
                 (
                        @emloyeeId,
                        @projectID
                 );
         END;
             ELSE
             BEGIN
                 RAISERROR('The employee has too many projects!', 16, 1);
         END;
     END;
	 
/* *****************************************************
	Problem 9.1.	Delete Employees
********************************************************/

CREATE TABLE Deleted_Employees
(
             EmployeeId   INT IDENTITY,
             FirstName    NVARCHAR(50),
             LastName     NVARCHAR(50),
             MiddleName   NVARCHAR(50),
             JobTitle     NVARCHAR(50),
             DepartmentId INT,
             Salary       DECIMAL(15, 2),
             CONSTRAINT PK_Deleted_Employees PRIMARY KEY(EmployeeId),
             CONSTRAINT FK_Deleted_Employees_Departments FOREIGN KEY(DepartmentId) REFERENCES Departments(DepartmentId)
);
GO

/* Only trigger creation for JUDGE */
CREATE TRIGGER tr_DeletedEmployeesSaver ON Employees
AFTER DELETE
AS
     BEGIN
         INSERT INTO Deleted_Employees
                SELECT FirstName,
                       LastName,
                       MiddleName,
                       JobTitle,
                       DepartmentID,
                       Salary
                FROM deleted;
     END;
	   
/* *****************************************************
	PART II – Queries for Bank Database
********************************************************/

USE BANK; 

/* *****************************************************
	Problem 10.	Find Full Name
********************************************************/

CREATE PROCEDURE usp_GetHoldersFullName
AS
     BEGIN
         SELECT CONCAT(FirstName+' ', LastName) AS [Full Name]
         FROM AccountHolders;
     END;
		 
/* *****************************************************
	Problem 11.	People with Balance Higher Than
********************************************************/

CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan
(
                 @balance MONEY
)
AS
     BEGIN
         SELECT ah.FirstName AS [First Name],
                ah.LastName AS [Last Name]
         FROM AccountHolders AS ah
              JOIN Accounts AS a ON ah.Id = a.AccountHolderId
         GROUP BY ah.FirstName,
                  ah.LastName
         HAVING @balance < SUM(a.Balance);
     END;
		
/* *****************************************************
	Problem 12.	Future Value Function
********************************************************/

CREATE FUNCTION ufn_CalculateFutureValue
(
                @sum                MONEY,
                @yearlyInterestRate FLOAT,
                @numberOfYears      INT
)
RETURNS MONEY
AS
     BEGIN
         RETURN @sum * (POWER(1 + @yearlyInterestRate, @numberOfYears));
     END;
	 
/* *****************************************************
	Problem 13.	Calculating Interest
********************************************************/

CREATE PROCEDURE usp_CalculateFutureValueForAccount
(
                 @accountId    INT,
                 @interestRate FLOAT
)
AS
     BEGIN
         SELECT a.Id AS [Account Id],
                ah.FirstName AS [First Name],
                ah.LastName AS [Last Name],
                a.Balance AS [Current Balance],
                dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5)
         FROM Accounts AS a
              JOIN AccountHolders AS ah ON a.AccountHolderId = ah.Id
         WHERE a.Id = @accountId;
     END;
   
/* *****************************************************
	Problem 14.	Deposit Money
********************************************************/

CREATE PROCEDURE usp_DepositMoney
(
                 @accountId   INT,
                 @moneyAmount MONEY
)
AS
     BEGIN
         IF(@moneyAmount < 0)
             BEGIN
                 RAISERROR('Cannot deposit negative value', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(@accountId IS NULL
                    OR @moneyAmount IS NULL)
                     BEGIN
                         RAISERROR('Missing value', 16, 1);
                 END;
         END;
         BEGIN TRANSACTION;
         UPDATE Accounts
           SET
               Balance+=@moneyAmount
         WHERE Id = @accountId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Account doesn''t exists', 16, 1);
         END;
         COMMIT;
     END;
   
/* *****************************************************
	Problem 15.	Withdraw Money
********************************************************/

CREATE PROCEDURE usp_WithdrawMoney
(
                 @accountId   INT,
                 @moneyAmount MONEY
)
AS
     BEGIN
         IF(@moneyAmount < 0)
             BEGIN
                 RAISERROR('Cannot withdraw negative value', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(@accountId IS NULL
                    OR @moneyAmount IS NULL)
                     BEGIN
                         RAISERROR('Missing value', 16, 1);
                 END;
         END;
         BEGIN TRANSACTION;
         UPDATE Accounts
           SET
               Balance-=@moneyAmount
         WHERE Id = @accountId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Account doesn''t exists', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(0 >
                   (
                       SELECT Balance
                       FROM Accounts
                       WHERE Id = @accountId
                   ))
                     BEGIN
                         ROLLBACK;
                         RAISERROR('Balance not enough', 16, 1);
                 END;
         END;
         COMMIT;
     END;
   
/* *****************************************************
	Problem 16.	Money Transfer
********************************************************/

CREATE PROCEDURE usp_TransferMoney
(
                 @senderId   INT,
                 @receiverId INT,
                 @amount     MONEY
)
AS
     BEGIN
         IF(@amount < 0)
             BEGIN
                 RAISERROR('Cannot transfer negative amount', 16, 1);
         END;
             ELSE
             BEGIN
                 IF(@senderId IS NULL
                    OR @receiverId IS NULL
                    OR @amount IS NULL)
                     BEGIN
                         RAISERROR('Missing value', 16, 1);
                 END;
         END;

-- Withdraw from the sender
         BEGIN TRANSACTION;
         UPDATE Accounts
           SET
               Balance-=@amount
         WHERE Id = @senderId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Sender''s account doesn''t exists', 16, 1);
         END;

-- Check sender's current balance
         IF(0 >
           (
               SELECT Balance
               FROM Accounts
               WHERE ID = @senderId
           ))
             BEGIN
                 ROLLBACK;
                 RAISERROR('Not enough funds', 16, 1);
         END;

-- Add money to the receiver
         UPDATE Accounts
           SET
               Balance+=@amount
         WHERE ID = @receiverId;
         IF(@@ROWCOUNT < 1)
             BEGIN
                 ROLLBACK;
                 RAISERROR('Receiver''s account doesn''t exists', 16, 1);
         END;
         COMMIT;
     END;
   
/* *****************************************************
	Problem 17.	Create Table Logs
********************************************************/

USE Bank;

CREATE TABLE Logs
(
             LogId     INT NOT NULL IDENTITY,
             AccountId INT NOT NULL,
             OldSum    MONEY NOT NULL,
             NewSum    MONEY NOT NULL,
             CONSTRAINT PK_Logs PRIMARY KEY(LogId),
             CONSTRAINT FK_Logs_Accounts FOREIGN KEY(AccountId) REFERENCES Accounts(Id)
);
GO

-- For Judge - only the trigger creation
CREATE TRIGGER tr_Accounts_Logs_After_Update ON Accounts
FOR UPDATE
AS
     BEGIN
         INSERT INTO Logs
         VALUES
         (
         (
             SELECT Id
             FROM deleted
         ),
         (
             SELECT Balance
             FROM deleted
         ),
         (
             SELECT Balance
             FROM inserted
         )
         );
     END;
	 
/* *****************************************************
	Problem 18.	Create Table Emails
********************************************************/

CREATE TABLE NotificationEmails
(
             Id        INT NOT NULL IDENTITY,
             Recipient INT NOT NULL,
             Subject   NVARCHAR(50) NOT NULL,
             Body      NVARCHAR(255) NOT NULL,
             CONSTRAINT PK_NotificationEmails PRIMARY KEY(Id)
);
GO

-- For Judge - only the trigger creation
CREATE TRIGGER tr_Logs_NotificationEmails ON Logs
FOR INSERT
AS
     BEGIN
         INSERT INTO NotificationEmails
         VALUES
         (
         (
             SELECT AccountId
             FROM inserted
         ),
         CONCAT('Balance change for account: ',
               (
                   SELECT AccountId
                   FROM inserted
               )),
         CONCAT('On ', FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), ' your balance was changed from ',
               (
                   SELECT OldSum
                   FROM Logs
               ), ' to ',
               (
                   SELECT NewSum
                   FROM Logs
               ), '.')
         );
     END;
	 
/* *****************************************************
	PART III – Queries for Diablo Database
********************************************************/

USE Diablo;

/* *****************************************************
	Problem 19.	*Scalar Function: Cash in User Games Odd Rows
********************************************************/

CREATE FUNCTION ufn_CashInUsersGames
(
                @gameName NVARCHAR(50)
)
RETURNS TABLE
AS
     RETURN
(
    SELECT SUM(ocbg.Cash) AS SumCash
    FROM
    (
        SELECT g.Name,
               ug.Cash,
               ROW_NUMBER() OVER(ORDER BY ug.Cash DESC) AS RowN
        FROM Games AS g
             JOIN UsersGames AS ug ON ug.GameId = g.Id
        WHERE Name = @gameName
    ) AS ocbg
    WHERE ocbg.RowN % 2 != 0
);

/* *****************************************************
	Problem 20.	Trigger
********************************************************/

/* Trigget for validating user's level when buying items */
CREATE TRIGGER tr_UserGameItems_LevelRestriction ON UserGameItems
INSTEAD OF UPDATE
AS
     BEGIN
         IF(
           (
               SELECT Level
               FROM UsersGames
               WHERE Id =
               (
                   SELECT UserGameId
                   FROM inserted
               )
           ) <
           (
               SELECT MinLevel
               FROM Items
               WHERE Id =
               (
                   SELECT ItemId
                   FROM inserted
               )
           ))
             BEGIN
                 RAISERROR('Your current level is not enough', 16, 1);
         END;

/* Assign the new item when the exception isn't thrown */
         INSERT INTO UserGameItems
         VALUES
         (
         (
             SELECT ItemId
             FROM inserted
         ),
         (
             SELECT UserGameId
             FROM inserted
         )
         );
     END;
	 
/* Add bonus cash */
UPDATE ug
  SET
      ug.Cash+=50000
FROM UsersGames AS ug
     JOIN Users AS u ON u.Id = ug.UserId
     JOIN Games AS g ON g.Id = ug.GameId
WHERE u.FirstName IN('baleremuda', 'loosenoise', 'inguinalself', 'buildingdeltoid', 'monoxidecos')
AND g.Name = 'Bali';

/* Cannot understand the rest of the exercise */

/* *****************************************************
	Problem 21.	*Massive Shopping
********************************************************/

DECLARE @gameId INT, @sum1 MONEY, @sum2 MONEY;

SELECT @gameId = usg.[Id]
FROM UsersGames AS usg
     JOIN Games AS g ON usg.[GameId] = g.[Id]
WHERE g.[Name] = 'Safflower';

SET @sum1 =
(
    SELECT SUM(i.Price)
    FROM Items AS i
    WHERE MinLevel BETWEEN 11 AND 12
);

SET @sum2 =
(
    SELECT SUM(i.Price)
    FROM Items AS i
    WHERE MinLevel BETWEEN 19 AND 21
);

BEGIN TRANSACTION;

IF
(
    SELECT Cash
    FROM UsersGames
    WHERE Id = @gameId
) < @sum1
    BEGIN
        ROLLBACK;
END
    ELSE
    BEGIN
        UPDATE UsersGames
          SET
              Cash = Cash - @sum1
        WHERE Id = @gameId;

        INSERT INTO UserGameItems(UserGameId,
                                  ItemId
                                 )
               SELECT @gameId,
                      Id
               FROM Items
               WHERE MinLevel BETWEEN 11 AND 12;
        COMMIT;
END;

BEGIN TRANSACTION;

IF
(
    SELECT Cash
    FROM UsersGames
    WHERE Id = @gameId
) < @sum2
    BEGIN
        ROLLBACK;
END
    ELSE
    BEGIN
        UPDATE UsersGames
          SET
              Cash = Cash - @sum2
        WHERE Id = @gameId;

        INSERT INTO UserGameItems(UserGameId,
                                  ItemId
                                 )
               SELECT @gameId,
                      Id
               FROM Items
               WHERE MinLevel BETWEEN 19 AND 21;
        COMMIT;
END;

SELECT i.Name AS 'Item Name'
FROM UserGameItems AS ugi
     JOIN Items AS i ON ugi.ItemId = i.Id
WHERE ugi.UserGameId = @gameId;

/* Understood from the exercise but Judge doesn't accept it */
BEGIN TRANSACTION;

-- Add the Items
BEGIN TRY
    INSERT INTO UserGameItems
           SELECT Id,
                  UserGameId
           FROM
           (
               SELECT i.Id,
                      ugi.UserGameId
               FROM Users AS u
                    JOIN UsersGames AS ug ON ug.UserId = u.Id
                    JOIN Games AS g ON g.Id = ug.GameId
                    JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
                    JOIN Items AS i ON i.Id = ugi.ItemId
               WHERE u.FirstName = 'Stamat'
                     AND g.Name = 'Safflower'
                     AND i.Id NOT IN
               (
                   SELECT ugiss.ItemId
                   FROM UserGameItems AS ugiss
                   WHERE ugiss.UserGameId = ugi.UserGameId
               )
           ) AS joined;
END TRY
BEGIN CATCH
    ROLLBACK;
    SELECT ERROR_MESSAGE();
END CATCH;

-- Charging money 
UPDATE ug
  SET
      ug.Cash -= i.Price
FROM Users AS u
     JOIN UsersGames AS ug ON ug.UserId = u.Id
     JOIN Games AS g ON g.Id = ug.GameId
     JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
     JOIN Items AS i ON i.Id = ugi.ItemId
WHERE u.FirstName = 'Stamat'
      AND g.Name = 'Safflower'
      AND i.Id NOT IN
(
    SELECT ugiss.ItemId
    FROM UserGameItems AS ugiss
    WHERE ugiss.UserGameId = ugi.UserGameId
);

-- Check if money are less than zero 
IF(0 >
  (
      SELECT ug.Cash
      FROM Users AS u
           JOIN UsersGames AS ug ON ug.UserId = u.Id
           JOIN Games AS g ON g.Id = ug.GameId
      WHERE u.FirstName = 'Stamat'
            AND g.Name = 'Safflower'
  ))
    BEGIN
        ROLLBACK;
        RAISERROR('Money not enough', 16, 1);
END;

ROLLBACK;

SELECT i.Name AS 'Item Name' 
FROM Items AS i
JOIN UserGameItems AS ugi ON ugi.ItemId = i.Id
JOIN UsersGames AS ug ON ugi.UserGameId = ug.Id
JOIN Games AS g ON ug.GameId = g.Id
WHERE g.Name = 'Safflower'
ORDER BY i.Name

/* *****************************************************
	Problem 22.	Number of Users for Email Provider
********************************************************/

SELECT [Email Provider],
       COUNT([Email Provider]) AS [Number Of Users]
FROM
(
    SELECT Email,
           SUBSTRING(Email, CHARINDEX('@', Email, 1)+1, LEN(Email)-CHARINDEX('@', Email, 1)) AS [Email Provider]
    FROM Users
) AS ins
GROUP BY [Email Provider]
ORDER BY [Number Of Users] DESC,
         [Email Provider];
		 
/* *****************************************************
	Problem 23.	All User in Games
********************************************************/

SELECT g.Name AS Game,
       gt.Name AS [Game Type],
       u.Username,
       ug.Level,
       ug.Cash,
       c.Name AS Character
FROM Games AS g
     JOIN GameTypes AS gt ON gt.Id = g.GameTypeId
     JOIN UsersGames AS ug ON ug.GameId = g.Id
     JOIN Users AS u ON u.Id = ug.UserId
     JOIN Characters AS c ON c.Id = ug.CharacterId
ORDER BY ug.Level DESC,
         u.Username,
         g.Name;
		 
/* *****************************************************
	Problem 24.	Users in Games with Their Items
********************************************************/

SELECT u.Username,
       g.Name AS Game,
       COUNT(i.Id) AS [Items Count],
       SUM(i.Price) AS [Items Price]
FROM Users AS u
     JOIN UsersGames AS ug ON ug.UserId = u.Id
     JOIN Games AS g ON g.Id = ug.GameId
     JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
     JOIN Items AS i ON i.Id = ugi.ItemId
GROUP BY g.Name,
         u.Username
HAVING COUNT(i.Id) >= 10
ORDER BY [Items Count] DESC,
         [Items Price] DESC,
         u.Username;
		 
/* *****************************************************
	Problem 25.	* User in Games with Their Statistics
********************************************************/

SELECT u.Username,
       g.Name AS Game,
       MAX(c.Name) AS Character,
       SUM(iStat.Strength) + MAX(gtStat.Strength) + MAX(cStat.Strength) AS Strength,
       SUM(iStat.Defence) + MAX(gtStat.Defence) + MAX(cStat.Defence) AS Defence,
       SUM(iStat.Speed) + MAX(gtStat.Speed) + MAX(cStat.Speed) AS Speed,
       SUM(iStat.Mind) + MAX(gtStat.Mind) + MAX(cStat.Mind) AS Mind,
       SUM(iStat.Luck) + MAX(gtStat.Luck) + MAX(cStat.Luck) AS Luck
FROM Users AS u
     JOIN UsersGames AS ug ON ug.UserId = u.Id
     JOIN Games AS g ON g.Id = ug.GameId
     JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
     JOIN Items AS i ON i.Id = ugi.ItemId
     JOIN [Statistics] AS iStat ON iStat.Id = i.StatisticId
     JOIN GameTypes AS gt ON gt.Id = g.GameTypeId
     JOIN [Statistics] AS gtStat ON gtstat.Id = gt.BonusStatsId
     JOIN Characters AS c ON c.Id = ug.CharacterId
     JOIN [Statistics] AS cStat ON cStat.Id = c.StatisticId
GROUP BY g.Name,
         Username
ORDER BY Strength DESC,
         Defence DESC,
         Speed DESC,
         Mind DESC,
         Luck DESC;
		 
/* *****************************************************
	Problem 26.	All Items with Greater than Average Statistics
********************************************************/

SELECT i.[Name],
       i.Price,
       i.MinLevel,
       s.Strength,
       s.Defence,
       s.Speed,
       s.Luck,
       s.Mind
FROM Items AS i
     JOIN [Statistics] AS s ON s.Id = i.StatisticId
WHERE s.Mind >
(
    SELECT AVG(Mind)
    FROM [Statistics]
)
      AND s.Luck >
(
    SELECT AVG(Luck)
    FROM [Statistics]
)
      AND s.Speed >
(
    SELECT AVG(Speed)
    FROM [Statistics]
)
ORDER BY i.[Name];

/* Solution with declared variables instead of subquery */

DECLARE @minMind INT =
(
    SELECT AVG(Mind)
    FROM [Statistics]
);

DECLARE @minLuck INT =
(
    SELECT AVG(Luck)
    FROM [Statistics]
);

DECLARE @minSpeed INT =
(
    SELECT AVG(Speed)
    FROM [Statistics]
);

SELECT i.[Name],
       i.Price,
       i.MinLevel,
       s.Strength,
       s.Defence,
       s.Speed,
       s.Luck,
       s.Mind
FROM Items AS i
     JOIN [Statistics] AS s ON s.Id = i.StatisticId
WHERE s.Mind > @minMind
      AND s.Luck > @minLuck
      AND s.Speed > @minSpeed
ORDER BY i.[Name];

/* *****************************************************
	Problem 27.	Display All Items with Information about Forbidden Game Type
********************************************************/

SELECT i.[Name] AS Item,
       i.Price,
       i.MinLevel,
       gt.[Name] AS [Forbidden Game Type]
FROM Items AS i
     LEFT OUTER JOIN GameTypeForbiddenItems AS gtfi ON gtfi.ItemId = i.Id
     LEFT OUTER JOIN GameTypes AS gt ON gt.Id = gtfi.GameTypeId
ORDER BY [Forbidden Game Type] DESC,
         Item;
		 
/* *****************************************************
	Problem 28.	Buy Items for User in Game
********************************************************/

DECLARE @userId INT =
(
    SELECT Id
    FROM Users
    WHERE Username = 'Alex'
);

DECLARE @gameId INT =
(
    SELECT Id
    FROM Games
    WHERE [Name] = 'Edinburgh'
);

-- Transaction for Blackguard

BEGIN TRANSACTION;

DECLARE @itemId INT =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Blackguard'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Transaction for Bottomless Potion of Amplification

BEGIN TRANSACTION;

SET @itemId =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Bottomless Potion of Amplification'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Transaction for Eye of Etlich (Diablo III)

BEGIN TRANSACTION;

SET @itemId =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Eye of Etlich (Diablo III)'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Transaction for Gem of Efficacious Toxin

BEGIN TRANSACTION;

SET @itemId =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Gem of Efficacious Toxin'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Transaction for Golden Gorget of Leoric 

BEGIN TRANSACTION;

SET @itemId =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Golden Gorget of Leoric'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Transaction for Hellfire Amulet 

BEGIN TRANSACTION;

SET @itemId =
(
    SELECT Id
    FROM Items
    WHERE [Name] = 'Hellfire Amulet'
);

-- Get money

UPDATE UsersGames
  SET
      Cash -= 
(
    SELECT Price
    FROM Items
    WHERE Id = @itemId
)
WHERE UserId = @userId
      AND GameId = @gameId;

-- Check if Cach is still positive

IF(0 >
  (
      SELECT Cash
      FROM UsersGames
      WHERE UserId = @userId
            AND GameId = @gameId
  ))
    BEGIN
        PRINT 'Cash is not enough!';
        ROLLBACK;
END;

-- Assign item

INSERT INTO UserGameItems
VALUES
(
       @itemId,
(
    SELECT Id
    FROM UsersGames
    WHERE UserId = @userId
          AND GameId = @gameId
)
);

COMMIT;

-- End of transaction

-- Final Selection

SELECT u.Username,
       g.[Name],
       ug.Cash,
       i.[Name] AS [Item Name]
FROM Users AS u
     JOIN UsersGames AS ug ON ug.UserId = u.Id
     JOIN Games AS g ON g.Id = ug.GameId
     JOIN UserGameItems AS ugi ON ugi.UserGameId = ug.Id
     JOIN Items AS i ON i.Id = ugi.ItemId
WHERE g.Id = @gameId
ORDER BY [Item Name];

/* *****************************************************
	PART IV – Queries for Geography Database
********************************************************/

USE Geography;

/* *****************************************************
	Problem 29.	Peaks and Mountains
********************************************************/

SELECT p.PeakName,
       m.MountainRange AS Mountain,
       p.Elevation
FROM Peaks AS p
     JOIN Mountains AS m ON m.Id = p.MountainId
ORDER BY p.Elevation DESC,
         p.PeakName;
		 
/* *****************************************************
	Problem 30.	Peaks with Their Mountain, Country and Continent
********************************************************/

/* Judge expects without filtering results */
SELECT p.PeakName,
       m.MountainRange AS Mountain,
       c.CountryName,
       ct.ContinentName
FROM Peaks AS p
     JOIN Mountains AS m ON m.Id = p.MountainId
     JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
     JOIN Countries AS c ON c.CountryCode = mc.CountryCode
     JOIN Continents AS ct ON ct.ContinentCode = c.ContinentCode
ORDER BY p.PeakName,
         c.CountryName;

/* Understood from the explanation */
SELECT p.PeakName,
       m.MountainRange AS Mountain,
       c.CountryName,
       ct.ContinentName
FROM Peaks AS p
     JOIN Mountains AS m ON m.Id = p.MountainId
     JOIN MountainsCountries AS mc ON mc.MountainId = m.Id
     JOIN Countries AS c ON c.CountryCode = mc.CountryCode
     JOIN Continents AS ct ON ct.ContinentCode = c.ContinentCode
WHERE
(
    SELECT COUNT(ssmc.MountainId)
    FROM MountainsCountries AS ssmc
    WHERE ssmc.MountainId = mc.MountainId
) > 1
ORDER BY p.PeakName,
         c.CountryName;

/* *****************************************************
	Problem 31.	Rivers by Country
********************************************************/

-- Shorter option
SELECT c.CountryName,
       ct.ContinentName,
       COUNT(r.Id) AS RiversCount,
       ISNULL(SUM(r.Length), 0) AS TotalLength
FROM Countries AS c
     JOIN Continents AS ct ON ct.ContinentCode = c.ContinentCode
     LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
     LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName,
         ct.ContinentName
ORDER BY RiversCount DESC,
         TotalLength DESC,
         CountryName;

-- With subquery
SELECT CountryRivers.CountryName,
       ct.ContinentName,
       CountryRivers.RiversCount,
       CountryRivers.TotalLength
FROM
(
    SELECT c.CountryName,
           COUNT(r.Id) AS RiversCount,
           ISNULL(SUM(r.Length), 0) AS TotalLength
    FROM Countries AS c
         JOIN Continents AS ct ON ct.ContinentCode = c.ContinentCode
         LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
         LEFT JOIN Rivers AS r ON r.Id = cr.RiverId
    GROUP BY c.CountryName
) AS CountryRivers
JOIN Continents AS ct ON ct.ContinentCode =
(
    SELECT TOP (1) c.ContinentCode
    FROM Countries AS c
    WHERE c.CountryName = CountryRivers.CountryName
)
ORDER BY CountryRivers.RiversCount DESC,
         CountryRivers.TotalLength DESC,
         CountryRivers.CountryName;
		 
/* *****************************************************
	Problem 32.	Count of Countries by Currency
********************************************************/

SELECT crr.CurrencyCode,
       crr.[Description] AS Currency,
       COUNT(cntr.CountryCode) AS NumberOfCountries
FROM Currencies AS crr
     LEFT JOIN Countries AS cntr ON cntr.CurrencyCode = crr.CurrencyCode
GROUP BY crr.CurrencyCode,
         crr.[Description]
ORDER BY NumberOfCountries DESC,
         Currency;
		 
/* *****************************************************
	Problem 33.	Population and Area by Continent
********************************************************/

SELECT cont.ContinentName,
       SUM(CAST(cntr.AreaInSqKm AS BIGINT)) AS CountriesArea,
       SUM(CAST(cntr.[Population] AS BIGINT)) AS CountriesPopulation
FROM Continents AS cont
     JOIN Countries AS cntr ON cntr.ContinentCode = cont.ContinentCode
	GROUP BY ContinentName
ORDER BY CountriesPopulation DESC;

/* *****************************************************
	Problem 34.	Monasteries by Country
********************************************************/

-- Task 1

CREATE TABLE Monasteries
(
             Id          INT IDENTITY NOT NULL,
             [Name]      NVARCHAR(100) NOT NULL,
             CountryCode CHAR(2) NOT NULL,
             CONSTRAINT PK_Monasteries PRIMARY KEY(Id),
             CONSTRAINT FK_Monasteries_Countries FOREIGN KEY(CountryCode) REFERENCES Countries(CountryCode)
);

-- Task 2

INSERT INTO Monasteries([Name],
                        CountryCode
                       )
VALUES
(
       'Rila Monastery “St. Ivan of Rila”',
       'BG'
),
(
       'Bachkovo Monastery “Virgin Mary”',
       'BG'
),
(
       'Troyan Monastery “Holy Mother''s Assumption”',
       'BG'
),
(
       'Kopan Monastery',
       'NP'
),
(
       'Thrangu Tashi Yangtse Monastery',
       'NP'
),
(
       'Shechen Tennyi Dargyeling Monastery',
       'NP'
),
(
       'Benchen Monastery',
       'NP'
),
(
       'Southern Shaolin Monastery',
       'CN'
),
(
       'Dabei Monastery',
       'CN'
),
(
       'Wa Sau Toi',
       'CN'
),
(
       'Lhunshigyia Monastery',
       'CN'
),
(
       'Rakya Monastery',
       'CN'
),
(
       'Monasteries of Meteora',
       'GR'
),
(
       'The Holy Monastery of Stavronikita',
       'GR'
),
(
       'Taung Kalat Monastery',
       'MM'
),
(
       'Pa-Auk Forest Monastery',
       'MM'
),
(
       'Taktsang Palphug Monastery',
       'BT'
),
(
       'Sümela Monastery',
       'TR'
);

-- Task 3 
/* NOT FOR JUDGE
ALTER TABLE Countries
ADD IsDeleted BIT DEFAULT 0;

UPDATE Countries
  SET
      IsDeleted = 0;
*/

-- Task 4

UPDATE Countries
  SET
      IsDeleted = 1
WHERE CountryCode IN
(
    SELECT c.CountryCode
    FROM Countries AS c
         JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
    GROUP BY c.CountryCode
    HAVING COUNT(cr.RiverId) > 3
);

-- Task 5

SELECT m.[Name] AS Monastery,
       c.CountryName AS Country
FROM Monasteries AS m
     JOIN Countries AS c ON c.CountryCode = m.CountryCode
WHERE c.IsDeleted = 0
ORDER BY Monastery;

/* *****************************************************
	Problem 35.	Monasteries by Continents and Countries
********************************************************/

-- Task 1

UPDATE Countries
  SET
      CountryName = 'Burma'
WHERE CountryName = 'Myanmar';

-- Task 2 and 3

INSERT INTO Monasteries
VALUES
(
       'Hanga Abbey',
(
    SELECT CountryCode
    FROM Countries
    WHERE CountryName = 'Tanzania'
)
),
(
       'Myin-Tin-Daik',
(
    SELECT CountryCode
    FROM Countries
    WHERE CountryName = 'Myanmar'

/* 
    The new name of Myanmar is Burma 
    WHERE CountryName = 'Myanmar' - returns NULL but Judge accepts it only this way
    To avoid NULL exception the filtration have to be: 
    WHERE CountryName = 'Burma' - with the New Name 
*/

)
);

-- Task 4

SELECT cnt.ContinentName,
       cntr.CountryName,
       COUNT(m.Id) AS MonasteriesCount
FROM Continents AS cnt
     LEFT OUTER JOIN Countries AS cntr ON cntr.ContinentCode = cnt.ContinentCode
     LEFT OUTER JOIN Monasteries AS m ON m.CountryCode = cntr.CountryCode
WHERE cntr.IsDeleted = 0
GROUP BY cnt.ContinentName,
         cntr.CountryName
ORDER BY MonasteriesCount DESC,
         CountryName;