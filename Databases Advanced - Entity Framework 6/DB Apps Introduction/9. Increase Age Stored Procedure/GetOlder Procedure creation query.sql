CREATE PROCEDURE usp_GetOlder
(
                 @minionId INT
)
AS
     BEGIN
         UPDATE Minions
           SET
               Age+=1
         WHERE Id = @minionId;
     END;