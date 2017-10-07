/* ******************************************
	Scripts for the creation of used Databases are here:
	https://github.com/RAstardzhiev/Software-University-SoftUni/tree/master/Databases%20Basics%20-%20MS%20SQL%20Server/Databases
*********************************************/

CREATE DATABASE TableRelations;
GO

USE TableRelations; 

/* ******************************************
	Problem 1.	One-To-One Relationship
*********************************************/

CREATE TABLE Passports
(
             PassportID     INT IDENTITY(101, 1) NOT NULL,
             PassportNumber CHAR(8) NOT NULL,
             CONSTRAINT PK_Passports PRIMARY KEY(PassportID)
);

CREATE TABLE Persons
(
             PersonId   INT IDENTITY NOT NULL,
             FirstName  NVARCHAR(50) NOT NULL,
             Salary     DECIMAL(10, 2),
             PassportID INT
             UNIQUE NOT NULL,
             CONSTRAINT PK_Persons PRIMARY KEY(PersonId),
             CONSTRAINT FK_Persons_Passports FOREIGN KEY(PassportID) REFERENCES Passports(PassportID) ON DELETE CASCADE
);
GO

INSERT INTO Passports
VALUES
(
       'N34FG21B'
),
(
       'K65LO4R7'
),
(
       'ZE657QP2'
);

INSERT INTO Persons
VALUES
(
       'Roberto',
       43300.00,
       102
),
(
       'Tom',
       56100.00,
       103
),
(
       'Yana',
       60200.00,
       101
);

/* ******************************************
	Problem 2.	One-To-Many Relationship
*********************************************/

CREATE TABLE Manufacturers
(
             ManufacturerID INT IDENTITY NOT NULL,
             Name           VARCHAR(50) NOT NULL,
             EstablishedOn  DATE DEFAULT GETDATE(),
             CONSTRAINT PK_Manufacturers PRIMARY KEY(ManufacturerID)
);

CREATE TABLE Models
(
             ModelID        INT NOT NULL,
             Name           VARCHAR(50) NOT NULL,
             ManufacturerID INT NOT NULL,
             CONSTRAINT PK_Models PRIMARY KEY(ModelID),
             CONSTRAINT FK_Models_Manufacturers FOREIGN KEY(ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
);

INSERT INTO Manufacturers
VALUES
(
       'BMW',
       '07/03/1916'
),
(
       'Tesla',
       '01/01/2003'
),
(
       'Lada',
       '01/05/1966'
);

INSERT INTO Models
VALUES
(
       101,
       'X1',
       1
),
(
       102,
       'i6',
       1
),
(
       103,
       'Model S',
       2
),
(
       104,
       'Model X',
       2
),
(
       105,
       'Model 3',
       2
),
(
       106,
       'Nova',
       3
); 

/* ******************************************
	Problem 3.	Many-To-Many Relationship
*********************************************/

CREATE TABLE Students(StudentID INT IDENTITY NOT NULL, Name NVARCHAR(255) NOT NULL CONSTRAINT PK_Students PRIMARY KEY(StudentID)); 

CREATE TABLE Exams(ExamID INT NOT NULL, Name NVARCHAR(255) NOT NULL CONSTRAINT PK_Exams PRIMARY KEY(ExamID));

CREATE TABLE StudentsExams
(
             StudentID INT NOT NULL,
             ExamID    INT NOT NULL,
             CONSTRAINT PK_StudentsExams PRIMARY KEY(StudentID, ExamID),
             CONSTRAINT FK_StudentsExams_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
             CONSTRAINT FK_StudentsExams_Exams FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
);

INSERT INTO Students
VALUES
(
       'Mila'
),
(
       'Toni'
),
(
       'Ron'
);

INSERT INTO Exams
VALUES
(
       101,
       'SpringMVC'
),
(
       102,
       'Neo4j'
),
(
       103,
       'Oracle 11g'
);

INSERT INTO StudentsExams
VALUES
(
       1,
       101
),
(
       1,
       102
),
(
       2,
       101
),
(
       3,
       103
),
(
       2,
       102
),
(
       2,
       103
); 

/* ******************************************
	Problem 4.	Self-Referencing 
*********************************************/

CREATE TABLE Teachers
(
             TeacherID INT NOT NULL,
             Name      NVARCHAR(255),
             ManagerID INT,
             CONSTRAINT PK_Teachers PRIMARY KEY(TeacherID),
             CONSTRAINT FK_Teachers_Teachers FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers
VALUES
(
       101,
       'John',
       NULL
),
(
       102,
       'Maya',
       106
),
(
       103,
       'Silvia',
       106
),
(
       104,
       'Ted',
       105
),
(
       105,
       'Mark',
       101
),
(
       106,
       'Greta',
       101
); 

/* ******************************************
	Problem 5.	Online Store Database 
*********************************************/

CREATE DATABASE OnlineStore;
GO

USE OnlineStore;

CREATE TABLE ItemTypes
(
             ItemTypeID INT NOT NULL,
             Name       VARCHAR(50) NOT NULL,
             CONSTRAINT PK_ItemTypes PRIMARY KEY(ItemTypeId)
);

CREATE TABLE Items
(
             ItemID     INT NOT NULL,
             Name       VARCHAR(50) NOT NULL,
             ItemTypeID INT NOT NULL,
             CONSTRAINT PK_Items PRIMARY KEY(ItemID),
             CONSTRAINT FK_Items_ItemTypes FOREIGN KEY(ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
);

CREATE TABLE Cities
(
             CityID INT NOT NULL,
             Name   VARCHAR(50) NOT NULL,
             CONSTRAINT PK_Cities PRIMARY KEY(CityID)
);

CREATE TABLE Customers
(
             CustomerID INT NOT NULL,
             Name       VARCHAR(50) NOT NULL,
             Birthday   DATE,
             CityID     INT,
             CONSTRAINT PK_Customers PRIMARY KEY(CustomerID),
             CONSTRAINT FK_Customers_Cities FOREIGN KEY(CityID) REFERENCES Cities(CityID)
);

CREATE TABLE Orders
(
             OrderID    INT NOT NULL,
             CustomerID INT NOT NULL,
             CONSTRAINT PK_Orders PRIMARY KEY(OrderID),
             CONSTRAINT FK_Orders_Customers FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderItems
(
             OrderID INT NOT NULL,
             ItemID  INT NOT NULL,
             CONSTRAINT PK_OrderItems PRIMARY KEY(OrderID, ItemID),
             CONSTRAINT FK_OrderItems_Orders FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
             CONSTRAINT FK_OrderItems_Items FOREIGN KEY(ItemID) REFERENCES Items(ItemID)
); 

/* ******************************************
	Problem 6.	University Database 
*********************************************/

CREATE DATABASE University;
GO

USE University;

CREATE TABLE Majors
(
             MajorID INT NOT NULL,
             Name    NVARCHAR(50),
             CONSTRAINT PK_Majors PRIMARY KEY(MajorID)
);

CREATE TABLE Students
(
             StudentID     INT NOT NULL,
             StudentNumber INT NOT NULL,
             StudentName   NVARCHAR(255),
             MajorID       INT,
             CONSTRAINT PK_Students PRIMARY KEY(StudentID),
             CONSTRAINT FK_Students_Majors FOREIGN KEY(MajorID) REFERENCES Majors(MajorID)
);

CREATE TABLE Payments
(
             PaymentID     INT NOT NULL,
             PaymentDate   DATE DEFAULT GETDATE(),
             PaymentAmount DECIMAL(10, 2) NOT NULL,
             StudentID     INT NOT NULL,
             CONSTRAINT PK_Payments PRIMARY KEY(PaymentID),
             CONSTRAINT FK_Payments_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE Subjects
(
             SubjectID   INT NOT NULL,
             SubjectName NVARCHAR(255) NOT NULL,
             CONSTRAINT PK_Subjects PRIMARY KEY(SubjectID)
);

CREATE TABLE Agenda
(
             StudentID INT NOT NULL,
             SubjectID INT NOT NULL,
             CONSTRAINT PK_Agenda_StudentID_SubjectID PRIMARY KEY(StudentID, SubjectID),
             CONSTRAINT FK_Agenda_Students FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
             CONSTRAINT FK_Agenda_Subjects FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
); 

/* ******************************************
	Problem 9.	*Peaks in Rila 
*********************************************/

USE Geography;

SELECT MountainRange,
       PeakName,
       Elevation
FROM Peaks
     JOIN Mountains ON Peaks.MountainId = Mountains.Id
WHERE Peaks.MountainId =
(
    SELECT Id
    FROM Mountains
    WHERE MountainRange = 'Rila'
)
ORDER BY Peaks.Elevation DESC;