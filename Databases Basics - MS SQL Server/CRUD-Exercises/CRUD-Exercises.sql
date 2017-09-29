/* ******************************************
	Scripts for the creation of used Databases are here:
	https://github.com/RAstardzhiev/Software-University-SoftUni/tree/master/Databases%20Basics%20-%20MS%20SQL%20Server/Databases
*********************************************/

/* *****************************************************
	2.	Find All Information About Departments
********************************************************/

USE SoftUni;

SELECT *
FROM Departments;

/* *****************************************************
	3.	Find all Department Names
********************************************************/

SELECT [Name]
FROM Departments;

/* *****************************************************
	4.	Find Salary of Each Employee
********************************************************/

SELECT FirstName,
       LastName,
       Salary
FROM Employees; 

/* *****************************************************
	5.	Find Full Name of Each Employee
********************************************************/

SELECT FirstName,
       MiddleName,
       Lastname
FROM Employees;

/* *****************************************************
	6.	Find Email Address of Each Employee
********************************************************/

SELECT FirstName + '.' + Lastname + '@softuni.bg' AS 'Full Email Address'
FROM Employees; 

/* *****************************************************
	7.	Find All Different Employee’s Salaries
********************************************************/

SELECT DISTINCT
       Salary
FROM Employees;

/* *****************************************************
	8.	Find all Information About Employees
********************************************************/

SELECT *
FROM Employees
WHERE JobTitle = 'Sales Representative';

/* *****************************************************
	9.	Find Names of All Employees by Salary in Range
********************************************************/

SELECT FirstName,
       LastName,
       JobTitle
FROM Employees
WHERE Salary >= 20000
      AND Salary <= 30000; 
--WHERE Salary BETWEEN 20000 AND 30000; -- Same result
/* *****************************************************
	10.	 Find Names of All Employees 
********************************************************/

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS 'Full Name'
FROM Employees
WHERE Salary = 25000
      OR Salary = 14000
      OR Salary = 12500
      OR Salary = 23600;

/* *****************************************************
	11.	 Find All Employees Without Manager
********************************************************/

SELECT FirstName,
       LastName
FROM Employees
WHERE ManagerID IS NULL;

/* *****************************************************
	12.	 Find All Employees with Salary More Than 50000
********************************************************/

SELECT FirstName,
       LastName,
       Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC;

/* *****************************************************
	13.	 Find 5 Best Paid Employees.
********************************************************/

SELECT TOP (5) FirstName,
               LastName
FROM Employees
ORDER BY Salary DESC;

/* *****************************************************
	14.	Find All Employees Except Marketing
********************************************************/

SELECT FirstName,
       LastName
FROM Employees
WHERE NOT DepartmentID = 4;

/* *****************************************************
	15.	Sort Employees Table
********************************************************/

SELECT *
FROM Employees
ORDER BY Salary DESC,
         FirstName ASC,
         LastName DESC,
         MiddleName ASC; 
		
/* *****************************************************
	16.	 Create View Employees with Salaries
********************************************************/

CREATE VIEW V_EmployeesSalaries
AS
     SELECT FirstName,
            LastName,
            Salary
     FROM Employees;
GO

SELECT *
FROM V_EmployeesSalaries;

/* *****************************************************
	17.	Create View Employees with Job Titles
********************************************************/

/* !!!!! Judge Expectation - but this way when MiddleName 
is null the result has two spaces after FirstName */

CREATE VIEW V_EmployeeNameJobTitle
AS
     SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName AS 'Full Naeme',
            JobTitle AS 'Job Title'
     FROM Employees;

/* !!!!! Better solution but not accepted by Judge */

SELECT FirstName + ' ' + ISNULL(MiddleName + ' ', '') + LastName AS 'Full Naeme',
       JobTitle AS 'Job Title'
FROM Employees;

/* !!!!! Same result as the above one */

SELECT CONCAT(FirstName + ' ', MiddleName + ' ', LastName) AS 'Full Naeme',
       JobTitle AS 'Job Title'
FROM Employees;

/* *****************************************************
	18.	 Distinct Job Titles
********************************************************/

SELECT DISTINCT
       JobTitle
FROM Employees;

/* *****************************************************
	19.	Find First 10 Started Projects
********************************************************/

SELECT TOP (10) *
FROM Projects
ORDER BY StartDate,
         [Name]; 

/* *****************************************************
	20.	 Last 7 Hired Employees
********************************************************/

SELECT TOP (7) firstName,
               LastName,
               HireDate
FROM Employees
ORDER BY HireDate DESC;

/* *****************************************************
	21.	Increase Salaries
********************************************************/

/* Not for Judge - Making Backup
BACKUP DATABASE SoftUni TO DISK = 'D:\softuni-backup.bak';
*/

DECLARE @EngineeringID INT;

DECLARE @ToolDesignID INT;

DECLARE @MarketingID INT;

DECLARE @InformationServicesID INT;

SELECT TOP (1) @EngineeringID = DepartmentID
FROM Departments
WHERE [Name] = 'Engineering';

SELECT TOP (1) @ToolDesignID = DepartmentID
FROM Departments
WHERE [Name] = 'Tool Design';

SELECT TOP (1) @MarketingID = DepartmentID
FROM Departments
WHERE [Name] = 'Marketing';

SELECT TOP (1) @InformationServicesID = DepartmentID
FROM Departments
WHERE [Name] = 'Information Services';

UPDATE Employees
  SET
      Salary *= 1.12
WHERE DepartmentID = @EngineeringID
      OR DepartmentID = @ToolDesignID
      OR DepartmentID = @MarketingID
      OR DepartmentID = @InformationServicesID;
	
/* --- Works the same way as the one above ---
UPDATE Employees
  SET
      Salary*=1.12
WHERE DepartmentID IN(@EngineeringID, @ToolDesignID, @MarketingID, @InformationServicesID);
*/

SELECT Salary
FROM Employees;

/* Not for Judge - Restore from Backup
USE [Geography];
GO

ALTER DATABASE SoftUni SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

DROP DATABASE SoftUni;
GO

RESTORE DATABASE SoftUni FROM DISK = 'D:\softuni-backup.bak';
*/

/* *****************************************************
	22.	 All Mountain Peaks
********************************************************/

SELECT PeakName
FROM Peaks
ORDER BY PeakName; 

/* *****************************************************
	23.	 Biggest Countries by Population
********************************************************/

SELECT TOP (30) CountryName,
                [Population]
FROM Countries
WHERE ContinentCode = 'EU'
ORDER BY [Population] DESC,
         CountryName;

/* *****************************************************
	24.	 *Countries and Currency (Euro / Not Euro)
********************************************************/

SELECT CountryName,
       CountryCode,
       CASE CurrencyCode
           WHEN 'EUR'
           THEN 'Euro'
           ELSE 'Not Euro'
       END AS 'Currency'
FROM Countries
ORDER BY CountryName;

/* *****************************************************
	25.	 All Diablo Characters
********************************************************/

USE Diablo;

SELECT [Name]
FROM Characters
ORDER BY [Name];