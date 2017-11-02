SELECT Name
FROM Towns
WHERE CountryId =
(
    SELECT Id
    FROM Countries
    WHERE Name = @countryName
);