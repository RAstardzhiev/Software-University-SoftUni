DECLARE @minionId INT=
(
    SELECT TOP (1) Id
    FROM Minions
    WHERE Name = @minionName
);

DECLARE @villainId INT=
(
    SELECT TOP (1) Id
    FROM Villains
    WHERE Name = @villainName
);

INSERT INTO MinionsVillains
VALUES
(
       @minionId,
       @villainId
);