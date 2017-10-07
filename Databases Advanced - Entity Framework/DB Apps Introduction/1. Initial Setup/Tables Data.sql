CREATE TABLE Countries
(
             Id   INT IDENTITY,
             Name NVARCHAR(50) NOT NULL,
             CONSTRAINT PK_Countries PRIMARY KEY(Id)
);

CREATE TABLE Towns
(
             Id        INT IDENTITY,
             Name      NVARCHAR(50) UNIQUE NOT NULL,
             CountryId INT NOT NULL,
             CONSTRAINT PK_Towns PRIMARY KEY(Id),
             CONSTRAINT FK_Towns_Countries FOREIGN KEY(CountryId) REFERENCES Countries(Id)
);

CREATE TABLE Minions
(
             Id     INT IDENTITY,
             Name   NVARCHAR(50) NOT NULL,
             Age    INT NOT NULL,
             TownId INT NOT NULL,
             CONSTRAINT PK_Minions PRIMARY KEY(Id),
             CONSTRAINT FK_Minions_Towns FOREIGN KEY(TownId) REFERENCES Towns(Id)
);

CREATE TABLE Villains
(
             Id             INT IDENTITY,
             Name           NVARCHAR(50) NOT NULL,
             EvilnessFactor NVARCHAR(25) NOT NULL,
             CONSTRAINT PK_Villains PRIMARY KEY(Id)
);

CREATE TABLE MinionsVillains
(
             MinionId  INT,
             VillainId INT,
             CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId),
             CONSTRAINT FK_MinionsVillains_Minions FOREIGN KEY(MinionId) REFERENCES Minions(Id),
             CONSTRAINT FK_MinionsVillains_Villains FOREIGN KEY(VillainId) REFERENCES Villains(Id)
);

INSERT INTO Countries
VALUES
(
       'Russia'
),
(
       'Bulgaria'
),
(
       'China'
),
(
       'USA'
),
(
       'Canada'
);

INSERT INTO Towns
VALUES
(
       'Moscow',
       1
),
(
       'Sofia',
       2
),
(
       'Ciung Dzang',
       3
),
(
       'Chicago',
       4
),
(
       'Ontario',
       5
);

INSERT INTO Minions
VALUES
(
       'Stuart',
       15,
       3
),
(
       'Josh',
       7,
       4
),
(
       'Vanq',
       35,
       1
),
(
       'Tervel',
       29,
       2
),
(
       'John',
       47,
       5
);

INSERT INTO Villains
VALUES
(
       'Bad Guy',
       'Bad'
),
(
       'Evil Guy',
       'Evil'
),
(
       'Good Dude',
       'Good'
),
(
       'Good Friend',
       'Good'
),
(
       'Super Evil Guy',
       'Super evil'
);

INSERT INTO MinionsVillains
VALUES
(
       1,
       3
),
(
       2,
       4
),
(
       3,
       5
),
(
       4,
       1
),
(
       5,
       2
),
(
       3,
       4
),
(
       2,
       1
),
(
       5,
       3
);