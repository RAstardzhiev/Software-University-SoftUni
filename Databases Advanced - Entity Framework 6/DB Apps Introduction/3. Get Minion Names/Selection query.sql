SELECT v.Name AS VillainName,
       m.Name AS MinionName,
       m.Age AS MinionAge
FROM Villains AS v
     LEFT JOIN MinionsVillains AS vm ON vm.VillainId = v.Id
     LEFT JOIN Minions AS m ON m.Id = vm.MinionId
WHERE v.Id = @villainId;