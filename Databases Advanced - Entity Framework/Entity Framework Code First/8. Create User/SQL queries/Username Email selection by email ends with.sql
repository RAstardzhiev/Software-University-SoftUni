SELECT CONCAT(Username, ' ', Email)
FROM Users
WHERE RIGHT(Email, LEN(@endsWith)) = @endsWith;