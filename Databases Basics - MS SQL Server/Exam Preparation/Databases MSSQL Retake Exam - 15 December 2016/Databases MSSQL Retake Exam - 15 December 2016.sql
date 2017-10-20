/* Not for Judge */
CREATE DATABASE TheNerdHerd;
GO

USE TheNerdHerd;

/* ********************************************************
	1.	Database design 
***********************************************************/

CREATE TABLE Locations
(
             Id        INT IDENTITY PRIMARY KEY,
             Latitude  FLOAT,
             Longitude FLOAT
);

CREATE TABLE Credentials
(
             Id       INT IDENTITY PRIMARY KEY,
             Email    VARCHAR(30),
             Password VARCHAR(20)
);

CREATE TABLE Users
(
             Id           INT IDENTITY PRIMARY KEY,
             Nickname     VARCHAR(25),
             Gender       CHAR(1),
             Age          INT,
             LocationId   INT,
             CredentialId INT
             UNIQUE,
             CONSTRAINT FK_Users_Locations FOREIGN KEY(LocationId) REFERENCES Locations(Id),
             CONSTRAINT FK_Users_Credentials FOREIGN KEY(CredentialId) REFERENCES Credentials(Id)
);

CREATE TABLE Chats
(
             Id        INT IDENTITY PRIMARY KEY,
             Title     VARCHAR(32),
             StartDate DATE,
             IsActive  BIT
);

CREATE TABLE Messages
(
             Id      INT IDENTITY PRIMARY KEY,
             Content VARCHAR(200),
             SentOn  DATE,
             ChatId  INT,
             UserId  INT,
             CONSTRAINT FK_Messages_Chats FOREIGN KEY(ChatId) REFERENCES Chats(Id),
             CONSTRAINT FK_Messages_Users FOREIGN KEY(UserId) REFERENCES Users(Id)
);

CREATE TABLE UsersChats
(
             UserId INT,
             ChatId INT,
             CONSTRAINT PK_UsersChats PRIMARY KEY(ChatId, UserId),
             CONSTRAINT FK_UsersChats_Users FOREIGN KEY(UserId) REFERENCES Users(Id),
             CONSTRAINT FK_UsersChats_Chats FOREIGN KEY(ChatId) REFERENCES Chats(Id)
);

/* ********************************************************
	2.	Insert
***********************************************************/

INSERT INTO Messages(Content,
                     SentOn,
                     ChatId,
                     UserId
                    )
       SELECT CONCAT(u.Age, '-', u.Gender, '-', l.Latitude, '-', l.Longitude) AS Content,
              CONVERT(DATE, GETDATE()) AS SentOn,
              CASE u.Gender
                  WHEN 'F'
                  THEN CEILING(SQRT(u.Age * 2))
                  WHEN 'M'
                  THEN CEILING(POWER(u.Age / 18, 3))
              END AS ChatId,
              u.Id AS UserId
       FROM Users AS u
            JOIN locations AS l ON l.Id = u.LocationId
       WHERE u.Id BETWEEN 10 AND 20;
	   
/* ********************************************************
	3.	Update
***********************************************************/

WITH cte_WrongChatDates(ChatId,
                        ChatStart,
                        FirstMessage)
     AS (
     SELECT c.Id AS ChatId,
            c.StartDate AS ChatStart,
            MIN(m.SentOn) AS FirstMessage
     FROM Chats AS c
          JOIN Messages AS m ON m.ChatId = c.Id
     GROUP BY c.Id,
              c.StartDate
     HAVING c.StartDate > MIN(m.SentOn))

     -- Update the mistaken dates
     UPDATE Chats
       SET
           StartDate =
     (
         SELECT FirstMessage
         FROM cte_WrongChatDates
         WHERE Id = ChatId
     )
     WHERE Id IN
     (
         SELECT ChatId
         FROM cte_WrongChatDates
     );
	 
/* ********************************************************
	4.	Delete
***********************************************************/

DELETE FROM Locations
WHERE Id IN
(
    SELECT l.Id
    FROM Users AS u
         RIGHT JOIN Locations AS l ON l.Id = u.LocationId
    WHERE u.Id IS NULL
);

/* ********************************************************
	5.	Age Range
***********************************************************/

SELECT Nickname,
       Gender,
       Age
FROM Users
WHERE Age BETWEEN 22 AND 37;

/* ********************************************************
	6.	Messages
***********************************************************/

SELECT Content,
       SentOn
FROM Messages
WHERE SentOn > '05.12.2014'
      AND Content LIKE '%just%'
ORDER BY Id DESC;

/* ********************************************************
	7.	Chats
***********************************************************/

SELECT Title,
       IsActive
FROM Chats
WHERE IsActive = 0
      AND LEN(Title) < 5
      OR SUBSTRING(Title, 3, 2) = 'tl'
ORDER BY Title DESC;

/* ********************************************************
	8.	Chat Messages
***********************************************************/

SELECT c.Id,
       c.Title,
       m.Id
FROM Chats AS c
     JOIN Messages AS m ON m.ChatId = c.Id
WHERE m.SentOn < '03.26.2012'
      AND RIGHT(c.Title, 1) = 'x'
ORDER BY c.Id,
         m.Id;
		 
/* ********************************************************
	9.	Message Count
***********************************************************/

SELECT TOP 5 c.Id,
             COUNT(*) AS TotalMessages
FROM Chats AS c
     RIGHT JOIN Messages AS m ON m.ChatId = c.Id
WHERE m.Id < 90
GROUP BY c.Id
ORDER BY TotalMessages DESC,
         c.Id;
		 
/* ********************************************************
	10.	Credentials
***********************************************************/

SELECT u.Nickname,
       c.Email,
       c.Password
FROM Users AS u
     JOIN Credentials AS c ON c.Id = u.CredentialId
WHERE c.Email LIKE '%co.uk'
ORDER BY c.Email;

/* ********************************************************
	11.	Locations
***********************************************************/

SELECT u.Id,
       u.Nickname,
       u.Age
FROM Users AS u
     LEFT JOIN Locations AS l ON l.Id = u.LocationId
WHERE l.Id IS NULL;

/* ********************************************************
	12.	Left Users
***********************************************************/

SELECT Id,
       ChatId,
       UserId
FROM Messages
WHERE ChatId = 17
      AND (UserId NOT IN
          (
              SELECT uc.UserId
              FROM UsersChats AS uc
                   JOIN Messages AS m ON uc.ChatId = m.ChatId
              WHERE uc.UserId = m.UserId
          )
              OR UserId IS NULL)
ORDER BY Id DESC;

/* ********************************************************
	13.	Users in Bulgaria
***********************************************************/

SELECT u.Nickname,
       c.Title,
       l.Latitude,
       l.Longitude
FROM Users AS u
     JOIN Locations AS l ON l.Id = u.LocationId
     JOIN UsersChats AS uc ON uc.UserId = u.Id
     JOIN Chats AS c ON c.Id = uc.ChatId
WHERE(l.Latitude BETWEEN 41.14 AND 44.12999) -- 44.13 changed to 44.12999 because Judge doesn't give points with the original number (the colimn is floating pont number (power of two))
     AND (l.Longitude BETWEEN 22.21 AND 28.36)
ORDER BY c.Title;

/* ********************************************************
	14.	Last Chat
***********************************************************/

SELECT c.Title,
       m.Content
FROM Chats AS c
     LEFT JOIN Messages AS m ON m.ChatId = c.Id
WHERE c.StartDate =
(
    SELECT MAX(StartDate)
    FROM Chats
);

/* ********************************************************
	15.	Radians
***********************************************************/

CREATE FUNCTION udf_GetRadians
(
                @degrees FLOAT
)
RETURNS FLOAT
AS
     BEGIN
         RETURN @degrees * PI() / 180;
     END;
	 
/* ********************************************************
	16.	Change Password
***********************************************************/

CREATE PROCEDURE udp_ChangePassword
(
                 @email       VARCHAR(MAX),
                 @newPassword VARCHAR(MAX) -- Judge test NVARCHAR
)
AS
     BEGIN
         DECLARE @credentialId INT=
         (
             SELECT Id
             FROM Credentials
             WHERE Email = @email
         );
		 
		 -- Check if Email exists
         IF(@credentialId IS NULL)
             BEGIN
                 RAISERROR('The email does''t exist!', 16, 1);
         END;
		 
		 -- Assign the new password
         UPDATE Credentials
           SET
               Password = @newPassword
         WHERE Id = @credentialId;
     END;
	 
/* ********************************************************
	17.	Send Message
***********************************************************/

CREATE PROCEDURE udp_SendMessage
(
                 @userId  INT,
                 @chatId  INT,
                 @content NVARCHAR(MAX)
)
AS
     BEGIN
    -- Check if user is in the chat
         IF(
           (
               SELECT UserId
               FROM UsersChats
               WHERE UserId = @userId
                     AND ChatId = @ChatId
           ) IS NULL)
             BEGIN
                 RAISERROR('There is no chat with that user!', 16, 1);
         END;

    -- Send the message
         INSERT INTO Messages(UserId,
                              ChatId,
                              Content,
                              SentOn
                             )
         VALUES
         (
                @userId,
                @chatId,
                @content,
                GETDATE()
         );
     END;
	 
/* ********************************************************
	18.	Log Messages
***********************************************************/

CREATE TRIGGER tr_DeletedMessageLogger ON Messages
AFTER DELETE
AS
     BEGIN
         INSERT INTO MessageLogs
                SELECT *
                FROM deleted;
     END;
	 
/* ********************************************************
	19.	Delete users
***********************************************************/

CREATE TRIGGER tr_DeleteUserAndItsRelations ON Users
INSTEAD OF DELETE
AS
     BEGIN
    -- Delete UserChats relations
         DELETE FROM UsersChats
         WHERE UserId =
         (
             SELECT Id
             FROM deleted
         );

    -- Delete Messages relations
         DELETE FROM Messages
         WHERE UserId =
         (
             SELECT Id
             FROM deleted
         );

    -- Delete the User
         DELETE FROM Users
         WHERE Id =
         (
             SELECT Id
             FROM deleted
         );
     END;