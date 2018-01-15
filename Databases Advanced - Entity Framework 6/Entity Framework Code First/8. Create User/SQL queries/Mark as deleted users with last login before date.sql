UPDATE Users
  SET
      IsDeleted = 1
WHERE LastTimeLoggedIn < @deletionsBefore
      AND IsDeleted = 0;