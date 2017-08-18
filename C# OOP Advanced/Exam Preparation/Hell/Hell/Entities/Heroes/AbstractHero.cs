using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public abstract class AbstractHero : IHero, IComparable<AbstractHero>
{
    private const string ItemAddedMessage = "Added item - {0} to Hero - {1}";
    private const string RecipeAddedMessage = "Added recipe - {0} to Hero - {1}";

    private IInventory inventory;
    private long strength;
    private long agility;
    private long intelligence;
    private long hitPoints;
    private long damage;

    protected AbstractHero(string name, int strength, int agility, int intelligence, int hitPoints, int damage) 
        : this(name, strength, agility, intelligence, hitPoints, damage, new HeroInventory())
    {
    }

    protected AbstractHero(string name, int strength, int agility, int intelligence, int hitPoints, int damage, IInventory inventory)
    {
        this.Name = name;
        this.Strength = strength;
        this.Agility = agility;
        this.Intelligence = intelligence;
        this.HitPoints = hitPoints;
        this.Damage = damage;
        this.inventory = inventory;
    }

    public string Name { get; private set; }

    public long Strength
    {
        get { return this.strength + this.inventory.TotalStrengthBonus; }
        set { this.strength = value; }
    }

    public long Agility
    {
        get { return this.agility + this.inventory.TotalAgilityBonus; }
        set { this.agility = value; }
    }

    public long Intelligence
    {
        get { return this.intelligence + this.inventory.TotalIntelligenceBonus; }
        set { this.intelligence = value; }
    }

    public long HitPoints
    {
        get { return this.hitPoints + this.inventory.TotalHitPointsBonus; }
        set { this.hitPoints = value; }
    }

    public long Damage
    {
        get { return this.damage + this.inventory.TotalDamageBonus; }
        set { this.damage = value; }
    }

    public long PrimaryStats
    {
        get { return this.Strength + this.Agility + this.Intelligence; }
    }

    public long SecondaryStats
    {
        get { return this.HitPoints + this.Damage; }
    }

    //REFLECTION
    public ICollection<IItem> Items
    {
        get
        {
            IDictionary<string, IItem> itemsAsDictionary = (IDictionary<string, IItem>)this.inventory
                .GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.Name.Equals($"{nameof(CommonItem)}s", StringComparison.OrdinalIgnoreCase))
                .GetValue(this.inventory);

            return itemsAsDictionary
                .Select(kvp => kvp.Value)
                .ToArray();
        }
    }

    public string AddRecipe(IRecipe recipe)
    {
        this.inventory.AddRecipeItem(recipe);
        return string.Format(RecipeAddedMessage, recipe.Name, this.Name);
    }

    public string AddItem(IItem item)
    {
        this.inventory.AddCommonItem(item);
        return string.Format(ItemAddedMessage, item.Name, this.Name);
    }

    public int CompareTo(AbstractHero other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }

        if (ReferenceEquals(null, other))
        {
            return 1;
        }

        int primary = this.PrimaryStats.CompareTo(other.PrimaryStats);
        if (primary != 0)
        {
            return primary;
        }

        return this.SecondaryStats.CompareTo(other.SecondaryStats);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Hero: {this.Name}, Class: {this.GetType().Name}")
            .AppendLine($"HitPoints: {this.HitPoints}, Damage: {this.Damage}")
            .AppendLine($"Strength: {this.Strength}")
            .AppendLine($"Agility: {this.Agility}")
            .AppendLine($"Intelligence: {this.Intelligence}")
            .AppendLine(this.Items.Count == 0
                ? "Items: None"
                : $"Items:{Environment.NewLine}{string.Join(Environment.NewLine, this.Items.Select(i => i.ToString()))}");

        return sb.ToString().TrimEnd();
    }
}