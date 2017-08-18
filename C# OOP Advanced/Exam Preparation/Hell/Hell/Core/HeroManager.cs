using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HeroManager : IHeroManager
{
    private const string CreadedHeroMessage = "Created {0} - {1}";
    private const string InvalidHeroTypeExceptionMessage = "Hero {0} doesn't exists";

    IList<IHero> heroes;
    Type[] heroTypes;

    public HeroManager() 
        : this(new List<IHero>(), new TypeCollector())
    {
    }

    public HeroManager(IEnumerable<IHero> heroes, ITypeCollector typeCollector)
        : this(heroes, typeCollector.GetAllInheritingTypes<IHero>())
    {
    }

    public HeroManager(IEnumerable<IHero> heroes, Type[] heroTypes)
    {
        this.heroes = heroes.ToList();
        this.heroTypes = heroTypes;
    }

    public string AddHero(IList<string> arguments)
    {
        string heroName = arguments[0];
        string heroType = arguments[1];

        Type typeOfHero = this.heroTypes
            .FirstOrDefault(t => t.Name.Equals(heroType, StringComparison.OrdinalIgnoreCase));

        if (typeOfHero == null)
        {
            throw new ArgumentException(string.Format(InvalidHeroTypeExceptionMessage, heroType));
        }

        IHero heroInstance = (IHero)Activator.CreateInstance(typeOfHero, heroName);
        this.heroes.Add(heroInstance);

        return string.Format(CreadedHeroMessage, heroType, heroName);
    }

    public string AddItemToHero(IList<string> arguments)
    {
        string itemName = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitPointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);

        IItem item = new CommonItem(itemName, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus);
        IHero hero = this.GetHero(heroName);

        return hero.AddItem(item);
    }

    public string AddRecipeToHero(IList<string> arguments)
    {
        string name = arguments[0];
        string heroName = arguments[1];
        int strengthBonus = int.Parse(arguments[2]);
        int agilityBonus = int.Parse(arguments[3]);
        int intelligenceBonus = int.Parse(arguments[4]);
        int hitpointsBonus = int.Parse(arguments[5]);
        int damageBonus = int.Parse(arguments[6]);
        string[] requiredItems = arguments.Skip(7).ToArray();

        IRecipe recipe = new RecipeItem(name, strengthBonus, agilityBonus, intelligenceBonus, hitpointsBonus, damageBonus, requiredItems);
        IHero hero = this.GetHero(heroName);

        return hero.AddRecipe(recipe);
    }

    public string Inspect(IList<string> arguments)
    {
        string heroName = arguments[0];
        IHero hero = this.GetHero(heroName);
        return hero.ToString();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        int heroNuber = 1;

        foreach (IHero currentHero in this.heroes
                                            .OrderByDescending(h => h.PrimaryStats)
                                            .ThenByDescending(h => h.SecondaryStats))
        {
            sb.AppendLine($"{heroNuber++}. {currentHero.GetType().Name}: {currentHero.Name}")
                .AppendLine($"###HitPoints: {currentHero.HitPoints}")
                .AppendLine($"###Damage: {currentHero.Damage}")
                .AppendLine($"###Strength: {currentHero.Strength}")
                .AppendLine($"###Agility: {currentHero.Agility}")
                .AppendLine($"###Intelligence: {currentHero.Intelligence}")
                .AppendLine(currentHero.Items.Count == 0
                    ? "###Items: None"
                    : $"###Items: {string.Join(", ", currentHero.Items.Select(item => item.Name))}");
        }

        return sb.ToString().TrimEnd();
    }

    private IHero GetHero(string heroName)
    {
        IHero hero = heroes.FirstOrDefault(h => h.Name.Equals(heroName, StringComparison.OrdinalIgnoreCase));
        if (hero == null)
        {
            throw new ArgumentException(string.Format(InvalidHeroTypeExceptionMessage, heroName));
        }

        return hero;
    }

}