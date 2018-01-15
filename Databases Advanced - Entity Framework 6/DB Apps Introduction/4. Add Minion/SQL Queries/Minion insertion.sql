DECLARE @townId INT=
(
    SELECT Id
    FROM Towns
    WHERE Name = @townName
);

INSERT INTO Minions
VALUES
(
       @name,
       @age,
       @townId
);