/* ******************************************
	Scripts for the creation of used Databases are here:
	https://github.com/RAstardzhiev/Software-University-SoftUni/tree/master/Databases%20Basics%20-%20MS%20SQL%20Server/Databases
*********************************************/

/* ******************************************
	Problem 1. Create Database
*********************************************/

CREATE DATABASE Minions;
GO

USE Minions;

/* ******************************************
	Problem 2. Create Tables
*********************************************/

CREATE TABLE Minions
(
             Id   INT NOT NULL PRIMARY KEY,
             Name VARCHAR(50) NOT NULL,
             Age  INT
);

CREATE TABLE Towns
(
             Id   INT NOT NULL PRIMARY KEY,
             Name VARCHAR(50) NOT NULL
);

/* ******************************************
	Problem 3. Alter Minions Table
*********************************************/

ALTER TABLE Minions
ADD TownId INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL;

--ALTER TABLE Minions
--ADD TownId INT NOT NULL;

--ALTER TABLE Minions
--ADD CONSTRAINT FK_TownId FOREIGN KEY(TownId) REFERENCES Towns(Id);
/* ******************************************
	Problem 4. Insert Records in Both Tables
*********************************************/

INSERT INTO Towns(Id,
                  Name
                 )
VALUES
(
       1,
       'Sofia'
),
(
       2,
       'Plovdiv'
),
(
       3,
       'Varna'
);

INSERT INTO Minions(Id,
                    Name,
                    Age,
                    TownId
                   )
VALUES
(
       1,
       'Kevin',
       22,
       1
),
(
       2,
       'Bob',
       15,
       3
),
(
       3,
       'Steward',
       NULL,
       2
);
	
/* ******************************************
	Problem 5. Truncate Table Minions
*********************************************/

TRUNCATE TABLE Minions;

/* ******************************************
	Problem 6. Drop All Tables
*********************************************/

DROP TABLE Minions;

DROP TABLE Towns;

/* ******************************************
	Problem 7. Create Table People
*********************************************/

CREATE TABLE People
(
             Id        INT
             UNIQUE IDENTITY NOT NULL,
             Name      NVARCHAR(200) NOT NULL,
             Picture   VARBINARY(MAX),
             Height    NUMERIC(3, 2),
             Weight    NUMERIC(5, 2),
             Gender    CHAR(1) CHECK([Gender] IN('M', 'F')) NOT NULL,
             Birthdate DATE NOT NULL,
             Biography NVARCHAR(MAX)
);

ALTER TABLE People
ADD PRIMARY KEY(Id);

ALTER TABLE People
ADD CONSTRAINT CH_PictureSize CHECK(DATALENGTH(Picture) <= 2 * 1024 * 1024);

INSERT INTO People(Name,
                   Gender,
                   Birthdate
                  )
VALUES
(
       'First Name',
       'M',
       '01-01-2000'
),
(
       'Second Name',
       'F',
       '05-03-2001'
),
(
       'Third Name',
       'F',
       '07-08-2005'
),
(
       'Fourth Name',
       'F',
       '03-05-2007'
),
(
       'Fifth Name',
       'M',
       '08-09-2003'
);
		
/* ******************************************
	Problem 8. Create Table Users
*********************************************/

CREATE TABLE Users
(
             Id             BIGINT
             UNIQUE IDENTITY NOT NULL,
             Username       VARCHAR(30)
             UNIQUE NOT NULL,
             Password       VARCHAR(26) NOT NULL,
             ProfilePicture VARBINARY(MAX),
             LastLoginTime  DATETIME2,
             IsDeleted      BIT NOT NULL
                                DEFAULT(0)
);

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(ID);

ALTER TABLE Users
ADD CONSTRAINT CH_ProfilePicture CHECK(DATALENGTH(ProfilePicture) <= 900 * 1024);

/* ********* TEST ProfilePicture CONSTRAINT *************
DECLARE @C VARCHAR(MAX)= '|';

DECLARE @ProfilePicture VARBINARY(MAX)= CONVERT(VARBINARY(MAX), REPLICATE(@C, (921600))); -- Must throw an exception
-- DECLARE @ProfilePicture VARBINARY(MAX) = CONVERT(VARBINARY(MAX), REPLICATE(@C, (921599))); -- Must pass through the size check

INSERT INTO Users(Id,
                  Username,
                  Password,
                  ProfilePicture
                 )
VALUES
(
       1,
       'Name',
       'Pass123456',
       @ProfilePicture
);
 */

INSERT INTO Users(Username,
                  Password
                 )
VALUES
(
       'First',
       'FpAsS'
),
(
       'Second',
       'SpAsS'
),
(
       'Third',
       'TpAsS'
),
(
       'Fourth',
       'FpAsS'
),
(
       'Fifth',
       'FfTpAsS'
);

/* ******************************************
	Problem 9. Change Primary Key
*********************************************/

ALTER TABLE Users DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Users PRIMARY KEY(Id, Username);

/* ******************************************
	Problem 10. Add Check Constraint
*********************************************/

ALTER TABLE Users
ADD CONSTRAINT Password CHECK(LEN(Password) >= 5);

/* ******************************************
	Problem 11. Set Default Value of a Field
*********************************************/

ALTER TABLE Users
ADD CONSTRAINT DF_Users DEFAULT GETDATE() FOR LastLoginTime;

/* ******************************************
	Problem 12. Set Unique Field
*********************************************/

ALTER TABLE Users DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Person PRIMARY KEY(Id);

ALTER TABLE Users
ADD CONSTRAINT UC_Users UNIQUE(Username);

ALTER TABLE Users
ADD CONSTRAINT CHK_Users CHECK(LEN(Password) >= 3);

/* ******************************************
	Problem 13. Movies Database
*********************************************/

CREATE DATABASE Movies;
GO

USE Movies;

CREATE TABLE Directors
(
             Id           INT NOT NULL PRIMARY KEY,
             DirectorName NVARCHAR(50) NOT NULL,
             Notes        NVARCHAR(MAX)
);

INSERT INTO Directors(Id,
                      DirectorName
                     )
VALUES
(
       1,
       'Director One'
),
(
       2,
       'Director Two'
),
(
       3,
       'Director Three'
),
(
       4,
       'Director Four'
),
(
       5,
       'Director Five'
);

CREATE TABLE Genres
(
             Id        INT NOT NULL PRIMARY KEY,
             GenreName NVARCHAR(50) NOT NULL,
             Notes     NVARCHAR(MAX)
);

INSERT INTO Genres(Id,
                   GenreName
                  )
VALUES
(
       1,
       'Genre One'
),
(
       2,
       'Genre Two'
),
(
       3,
       'Genre Three'
),
(
       4,
       'Genre Four'
),
(
       5,
       'Genre Five'
);

CREATE TABLE Categories
(
             Id           INT NOT NULL PRIMARY KEY,
             CategoryName NVARCHAR(50) NOT NULL,
             Notes        NVARCHAR(MAX)
);

INSERT INTO Categories(Id,
                       CategoryName
                      )
VALUES
(
       1,
       'Category One'
),
(
       2,
       'Category Two'
),
(
       3,
       'Category Three'
),
(
       4,
       'Category Four'
),
(
       5,
       'Category Five'
);

CREATE TABLE Movies
(
             Id            INT NOT NULL PRIMARY KEY,
             Title         NVARCHAR(255) NOT NULL,
             DirectorId    INT FOREIGN KEY REFERENCES Directors(Id),
             CopyrightYear INT,
             Length        NVARCHAR(50),
             GenreId       INT FOREIGN KEY REFERENCES Genres(Id),
             CategoryId    INT FOREIGN KEY REFERENCES Categories(Id),
             Rating        INT,
             Notes         NVARCHAR(MAX)
);

INSERT INTO Movies(Id,
                   Title,
                   DirectorId,
                   GenreId,
                   CategoryId
                  )
VALUES
(
       1,
       'Title One',
       2,
       3,
       4
),
(
       2,
       'Title Two',
       3,
       4,
       5
),
(
       3,
       'Title Three',
       1,
       2,
       3
),
(
       4,
       'Title Four',
       5,
       1,
       3
),
(
       5,
       'Title Five',
       3,
       5,
       2
);
		
/* ******************************************
	Problem 14. Car Rental Database
*********************************************/

CREATE DATABASE CarRental;
GO

USE CarRental;

CREATE TABLE Categories
(
             Id           INT
             PRIMARY KEY NOT NULL,
             CategoryName NVARCHAR(50) NOT NULL,
             DailyRate    DECIMAL(10, 2),
             WeeklyRate   DECIMAL(10, 2),
             MonthlyRate  DECIMAL(10, 2),
             WeekendRate  DECIMAL(10, 2)
);

ALTER TABLE Categories
ADD CONSTRAINT CK_AtLeastOneRate CHECK((DailyRate IS NOT NULL)
                                       OR (WeeklyRate IS NOT NULL)
                                       OR (MonthlyRate IS NOT NULL)
                                       OR (WeekendRate IS NOT NULL));

INSERT INTO Categories(Id,
                       CategoryName,
                       DailyRate,
                       WeeklyRate,
                       MonthlyRate,
                       WeekendRate
                      )
VALUES
(
       1,
       'First Category',
       10,
       50,
       200,
       50
),
(
       2,
       'Second Category',
       20,
       90,
       330,
       100
),
(
       3,
       'Third Category',
       30,
       130,
       2700,
       155
);

CREATE TABLE Cars
(
             Id           INT
             PRIMARY KEY NOT NULL,
             PlateNumber  VARCHAR(50) NOT NULL,
             Manufacturer VARCHAR(50) NOT NULL,
             Model        VARCHAR(50) NOT NULL,
             CarYear      INT NOT NULL,
             CategoryId   INT NOT NULL
                              FOREIGN KEY REFERENCES Categories(Id),
             Doors        TINYINT NOT NULL,
             Picture      VARBINARY(MAX),
             Condition    NVARCHAR(50),
             Available    BIT DEFAULT 1
);

INSERT INTO Cars(Id,
                 PlateNumber,
                 Manufacturer,
                 Model,
                 CarYear,
                 CategoryId,
                 Doors,
                 Available
                )
VALUES
(
       1,
       'CT7777CB',
       'BMW',
       '320',
       '2002',
       3,
       4,
       1
),
(
       2,
       'CT7557CB',
       'BMW',
       '535',
       '2009',
       3,
       4,
       1
),
(
       3,
       'CT7373CB',
       'BMW',
       '320',
       '1989',
       1,
       2,
       1
);

CREATE TABLE Employees
(
             Id        INT
             PRIMARY KEY NOT NULL,
             FirstName NVARCHAR(50) NOT NULL,
             LastName  NVARCHAR(50) NOT NULL,
             Title     NVARCHAR(50) NOT NULL,
             Notes     NVARCHAR(MAX)
);

INSERT INTO Employees(Id,
                      FirstName,
                      LastName,
                      Title
                     )
VALUES
(
       1,
       'First',
       'One',
       'Mechanic'
),
(
       2,
       'Second',
       'Two',
       'Team Leader'
),
(
       3,
       'Third',
       'Three',
       'Boss'
);

CREATE TABLE Customers
(
             Id                  INT NOT NULL PRIMARY KEY,
             DriverLicenceNumber VARCHAR(50)
             UNIQUE NOT NULL,
             FullName            NVARCHAR(50) NOT NULL,
             [Address]           NVARCHAR(255),
             City                NVARCHAR(50),
             ZIPCode             NVARCHAR(50),
             Notes               NVARCHAR(MAX)
);

INSERT INTO Customers(Id,
                      DriverLicenceNumber,
                      FullName
                     )
VALUES
(
       1,
       '123',
       'First Name'
),
(
       2,
       '234',
       'Second Name'
),
(
       3,
       '345',
       'Third Name'
);

CREATE TABLE RentalOrders
(
             Id               INT
             PRIMARY KEY NOT NULL,
             EmployeeId       INT NOT NULL
                                  FOREIGN KEY REFERENCES Employees(Id),
             CustomerId       INT NOT NULL
                                  FOREIGN KEY REFERENCES Customers(Id),
             CarId            INT NOT NULL
                                  FOREIGN KEY REFERENCES Cars(Id),
             TankLevel        NUMERIC(5, 2),
             KilometrageStart INT,
             KilometrageEnd   INT,
             TotalKilometrage INT,
             StartDate        DATE NOT NULL,
             EndDate          DATE NOT NULL,
             TotalDays        INT NOT NULL, 
	--TotalDays AS DATEDIFF(DAY, StartDate, EndDate), 
             RateApplied      DECIMAL(10, 2),
             TaxRate          DECIMAL(10, 2),
             OrderStatus      NVARCHAR(50),
             NOTES            NVARCHAR(MAX)
);

/* *** Verifying TotalDays is correct accrding dates *** */

ALTER TABLE RentalOrders
ADD CONSTRAINT CK_TotalDays CHECK(DATEDIFF(DAY, StartDate, EndDate) = TotalDays);

INSERT INTO RentalOrders(Id,
                         EmployeeId,
                         CustomerId,
                         CarId,
                         StartDate,
                         EndDate,
                         TotalDays
                        )
VALUES
(
       1,
       3,
       3,
       3,
       '01-01-2010',
       '01-02-2010',
       1
),
(
       2,
       1,
       1,
       1,
       '01-01-2010',
       '01-03-2010',
       2
),
(
       3,
       2,
       2,
       2,
       '01-01-2010',
       '01-04-2010',
       3
);

/* ******************************************
	Problem 15.	Hotel Database
*********************************************/

CREATE DATABASE Hotel;
GO

USE Hotel;

CREATE TABLE Employees
(
             Id        INT
             PRIMARY KEY NOT NULL,
             FirstName NVARCHAR(50) NOT NULL,
             LastName  NVARCHAR(50) NOT NULL,
             Title     NVARCHAR(255) NOT NULL,
             Notes     NVARCHAR(MAX)
);

INSERT INTO Employees(Id,
                      FirstName,
                      LastName,
                      Title
                     )
VALUES
(
       1,
       'First',
       'Employee',
       'Manager'
),
(
       2,
       'Second',
       'Employee',
       'Manager'
),
(
       3,
       'Third',
       'Employee',
       'Manager'
);

CREATE TABLE Customers
(
             AccountNumber   INT
             PRIMARY KEY NOT NULL,
             FirstName       NVARCHAR(50) NOT NULL,
             LastName        NVARCHAR(50) NOT NULL,
             PhoneNumber     VARCHAR(50),
             EmergencyName   NVARCHAR(50) NOT NULL,
             EmergencyNumber INT NOT NULL,
             Notes           NVARCHAR(50)
);

INSERT INTO Customers(AccountNumber,
                      FirstName,
                      LastName,
                      EmergencyName,
                      EmergencyNumber
                     )
VALUES
(
       1,
       'First',
       'Customer',
       'Em1',
       11111
),
(
       2,
       'Second',
       'Customer',
       'Em2',
       22222
),
(
       3,
       'Third',
       'Customer',
       'Em3',
       33333
);

CREATE TABLE RoomStatus
(
             RoomStatus NVARCHAR(50)
             PRIMARY KEY NOT NULL,
             Notes      NVARCHAR(MAX)
);

INSERT INTO RoomStatus(RoomStatus)
VALUES
(
       'Free'
),
(
       'In use'
),
(
       'Reserved'
);

CREATE TABLE RoomTypes
(
             RoomType NVARCHAR(50)
             PRIMARY KEY NOT NULL,
             Notes    NVARCHAR(MAX)
);

INSERT INTO RoomTypes(RoomType)
VALUES
(
       'Luxory'
),
(
       'Casual'
),
(
       'Misery'
);

CREATE TABLE BedTypes
(
             BedType NVARCHAR(50)
             PRIMARY KEY NOT NULL,
             Notes   NVARCHAR(MAX)
);

INSERT INTO BedTypes(BedType)
VALUES
(
       'Single'
),
(
       'Double'
),
(
       'King'
);

CREATE TABLE Rooms
(
             RoomNumber INT
             PRIMARY KEY NOT NULL,
             RoomType   NVARCHAR(50) NOT NULL,
             BedType    NVARCHAR(50) NOT NULL,
             Rate       DECIMAL(10, 2) NOT NULL,
             RoomStatus NVARCHAR(50) NOT NULL,
             Notes      NVARCHAR(MAX)
);

INSERT INTO Rooms(RoomNumber,
                  RoomType,
                  BedType,
                  Rate,
                  RoomStatus
                 )
VALUES
(
       1,
       'Luxory',
       'King',
       100,
       'Reserved'
),
(
       2,
       'Casual',
       'Double',
       50,
       'In use'
),
(
       3,
       'Misery',
       'Single',
       19,
       'Free'
);

CREATE TABLE Payments
(
             Id                INT
             PRIMARY KEY NOT NULL,
             EmployeeId        INT NOT NULL,
             PaymentDate       DATE NOT NULL,
             AccountNumber     INT NOT NULL,
             FirstDateOccupied DATE NOT NULL,
             LastDateOccupied  DATE NOT NULL,
             TotalDays         INT NOT NULL,
             AmountCharged     DECIMAL(10, 2) NOT NULL,
             TaxRate           DECIMAL(10, 2) NOT NULL,
             TaxAmount         DECIMAL(10, 2) NOT NULL,
             PaymentTotal      DECIMAL(10, 2) NOT NULL,
             Notes             NVARCHAR(MAX)
);

ALTER TABLE Payments
ADD CONSTRAINT CK_TotalDays CHECK(DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied) = TotalDays);

ALTER TABLE Payments
ADD CONSTRAINT CK_TaxAmount CHECK(TaxAmount = TotalDays * TaxRate);

INSERT INTO Payments(Id,
                     EmployeeId,
                     PaymentDate,
                     AccountNumber,
                     FirstDateOccupied,
                     LastDateOccupied,
                     TotalDays,
                     AmountCharged,
                     TaxRate,
                     TaxAmount,
                     PaymentTotal
                    )
VALUES
(
       1,
       1,
       '10-05-2015',
       1,
       '10-05-2015',
       '10-10-2015',
       5,
       75,
       50,
       250,
       75
),
(
       2,
       3,
       '10-11-2015',
       1,
       '12-15-2015',
       '12-25-2015',
       10,
       100,
       50,
       500,
       100
),
(
       3,
       2,
       '12-23-2015',
       1,
       '12-23-2015',
       '12-24-2015',
       1,
       75,
       75,
       75,
       75
);

CREATE TABLE Occupancies
(
             Id            INT
             PRIMARY KEY NOT NULL,
             EmployeeId    INT NOT NULL,
             DateOccupied  DATE NOT NULL,
             AccountNumber INT NOT NULL,
             RoomNumber    INT NOT NULL,
             RateApplied   DECIMAL(10, 2),
             PhoneCharge   VARCHAR(50) NOT NULL,
             Notes         NVARCHAR(MAX)
);

INSERT INTO Occupancies(Id,
                        EmployeeId,
                        DateOccupied,
                        AccountNumber,
                        RoomNumber,
                        PhoneCharge
                       )
VALUES
(
       1,
       2,
       '08-24-2012',
       3,
       1,
       '088 88 888 888'
),
(
       2,
       3,
       '06-15-2015',
       2,
       3,
       '088 88 555 555'
),
(
       3,
       1,
       '05-12-1016',
       1,
       2,
       '088 88 555 333'
);

/* ******************************************
	Problem 16. Create SoftUni Database
*********************************************/

CREATE DATABASE SoftUni;
GO

USE SoftUni;

CREATE TABLE Towns
(
             Id   INT
             PRIMARY KEY IDENTITY NOT NULL,
             Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Addresses
(
             Id          INT
             PRIMARY KEY IDENTITY NOT NULL,
             AddressText NVARCHAR(100) NOT NULL,
             TownId      INT FOREIGN KEY REFERENCES Towns(Id) NOT NULL
);

CREATE TABLE Departments
(
             Id     INT
             PRIMARY KEY IDENTITY NOT NULL,
             [Name] NVARCHAR(50) NOT NULL
);

CREATE TABLE Employees
(
             Id           INT
             PRIMARY KEY IDENTITY NOT NULL,
             FirstName    NVARCHAR(50) NOT NULL,
             MiddleName   NVARCHAR(50),
             LastName     NVARCHAR(50),
             JobTitle     NVARCHAR(100) NOT NULL,
             DepartmentId INT FOREIGN KEY REFERENCES Departments(Id) NOT NULL,
             HireDate     DATE,
             Salary       DECIMAL(10, 2) NOT NULL,
             AddressId    INT FOREIGN KEY REFERENCES Addresses(Id)
);

/* ******************************************
	Problem 17. Backup Database
*********************************************/

BACKUP DATABASE SoftUni TO DISK = 'D:\softuni-backup.bak';

USE CarRental;

DROP DATABASE SoftUni;

RESTORE DATABASE SoftUni FROM DISK = 'D:\softuni-backup.bak';

/* ******************************************
	Problem 18.	Basic Insert
*********************************************/

USE SoftUni;

INSERT INTO Towns(Name)
VALUES
(
       'Sofia'
),
(
       'Plovdiv'
),
(
       'Varna'
),
(
       'Burgas'
);

INSERT INTO Departments(Name)
VALUES
(
       'Engineering'
),
(
       'Sales'
),
(
       'Marketing'
),
(
       'Software Development'
),
(
       'Quality Assurance'
);

INSERT INTO Employees(FirstName,
                      MiddleName,
                      LastName,
                      JobTitle,
                      DepartmentId,
                      HireDate,
                      Salary
                     )
VALUES
(
       'Ivan',
       'Ivanov',
       'Ivanov',
       '.NET Developer',
       4,
       CONVERT(DATE, '02/03/2004', 103),
       3500.00
),
(
       'Petar',
       'Petrov',
       'Petrov',
       'Senior Engineer',
       1,
       CONVERT(DATE, '02/03/2004', 103),
       4000.00
),
(
       'Maria',
       'Petrova',
       'Ivanova',
       'Intern',
       5,
       CONVERT(DATE, '28/08/2016', 103),
       525.25
),
(
       'Georgi',
       'Teziev ',
       'Ivanov',
       'CEO',
       2,
       CONVERT(DATE, '09/12/2007', 103),
       3000.00
),
(
       'Peter',
       'Pan ',
       'Pan',
       'Intern',
       3,
       CONVERT(DATE, '28/08/2016', 103),
       599.88
);
		
/* ******************************************
	Problem 19. Basic Select All Fields
*********************************************/

SELECT *
FROM Towns;

SELECT *
FROM Departments;

SELECT *
FROM Employees;

/* ******************************************
	Problem 20. Basic Select All Fields and Order Them
*********************************************/

SELECT *
FROM Towns
ORDER BY Name ASC;

SELECT *
FROM Departments
ORDER BY Name ASC;

SELECT *
FROM Employees
ORDER BY Salary DESC;

/* ******************************************
	Problem 21.	Basic Select Some Fields
*********************************************/

SELECT [Name]
FROM Towns
ORDER BY [Name] ASC;

SELECT [Name]
FROM Departments
ORDER BY [Name] ASC;

SELECT [FirstName],
       [LastName],
       [JobTitle],
       [Salary]
FROM Employees
ORDER BY Salary DESC;

/* ******************************************
	Problem 22.	Increase Employees Salary
*********************************************/

UPDATE Employees
  SET
      Salary *= 1.10;

SELECT [Salary]
FROM Employees;

/* ******************************************
	Problem 23.	Decrease Tax Rate
*********************************************/

USE Hotel;

-- ALTER TABLE Payments
-- DROP CONSTRAINT [CK_TaxAmount];

UPDATE Payments
  SET
      TaxRate = TaxRate - (TaxRate * 0.03);

SELECT TaxRate
FROM Payments;

/* ******************************************
	Problem 24.	Delete All Records
*********************************************/

TRUNCATE TABLE Occupancies;

/* ----- DELETE Works but is slower than TRUNCATE -----
DELETE FROM Occupancies;
*/