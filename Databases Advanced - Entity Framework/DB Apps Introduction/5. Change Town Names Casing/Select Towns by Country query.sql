SELECT Name
FROM Towns
WHERE CountryId =
(
    SELECT Id
    FROM Countries
    WHERE name = @countryName
);