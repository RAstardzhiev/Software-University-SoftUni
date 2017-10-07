DECLARE @countryId INT=
(
    SELECT Id
    FROM Countries
    WHERE Name = @countryName
);

INSERT INTO Towns
VALUES
(
       @townName,
       @countryId
);