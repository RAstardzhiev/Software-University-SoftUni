UPDATE Towns
  SET
      Name = UPPER(Name)
WHERE CountryId =
(
    SELECT Id
    FROM Countries
    WHERE name = @countryName
);