using System.Collections.Generic;

public class RecipeItem : AbstractItem, IRecipe
{
    private IList<string> requiredItems;

    public RecipeItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus, IList<string> requiredItems) 
        : base(name, strengthBonus, agilityBonus, intelligenceBonus, hitPointsBonus, damageBonus)
    {
        this.requiredItems = requiredItems;
    }

    public IList<string> RequiredItems => this.requiredItems;
}
