UPDATE Minions
  SET
      Name = UPPER(LEFT(Name, 1)) + LOWER(RIGHT(Name, LEN(Name)-1)),
      Age += 1
WHERE Id IN(@idCollection);