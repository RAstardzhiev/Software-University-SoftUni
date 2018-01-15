SELECT FirstName
FROM
(
    SELECT DISTINCT
           e.EmployeeID,
           e.FirstName
    FROM Employees AS e
         JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
         JOIN Projects AS p ON p.ProjectID = ep.ProjectID
    WHERE DATEPART(YEAR, p.StartDate) = 2002
) AS EmployeeIdNameSelection;