SELECT Name,
       Age
FROM Minions AS m
     JOIN MinionsVillains AS mv ON mv.MinionId = m.Id
WHERE mv.VillainId = @villainId
ORDER BY m.Name;