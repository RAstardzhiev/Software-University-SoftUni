SELECT v.Name AS [Villain Name],
       COUNT(*) AS [Number of Minions]
FROM Villains AS v
     JOIN MinionsVillains AS mv ON mv.VillainId = v.Id
GROUP BY v.Name
HAVING COUNT(*) > 3
ORDER BY COUNT(*) DESC;