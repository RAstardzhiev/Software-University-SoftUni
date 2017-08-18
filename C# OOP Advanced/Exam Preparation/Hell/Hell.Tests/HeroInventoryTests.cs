using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[TestFixture]
public class HeroInventoryTests
{
    IInventory sut;

    [SetUp]
    public void TestInit()
    {
        this.sut = new HeroInventory();
    }

    [Test]
    public void AddCommonItemShouldSaveIt()
    {
        // Arrange
        IItem item = new CommonItem("Test", 10, 5, 15, 45, 67);
        IDictionary<string, IItem> collectionStoringItems = (IDictionary<string, IItem>)this.sut
            .GetType()
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(f => f.Name.Equals($"{nameof(CommonItem)}s", StringComparison.OrdinalIgnoreCase))
            .GetValue(this.sut);

        // Act 
        this.sut.AddCommonItem(item);

        // Assert
        Assert.AreEqual(1, collectionStoringItems.Count);
    }

    [Test]
    public void AddRecipeShouldSaveIt()
    {
        // Arrange
        List<string> requiredItems = new List<string>(new string[] { "f", "s", "t" });
        IRecipe recipe = new RecipeItem("recipe", 45, 86, 26, 34, 75, requiredItems);
        IDictionary<string, IRecipe> collectionStoringRecipes = (IDictionary<string, IRecipe>)this.sut
            .GetType()
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(f => f.Name.Equals($"{nameof(RecipeItem)}s", StringComparison.OrdinalIgnoreCase))
            .GetValue(this.sut);

        // Act 
        this.sut.AddRecipeItem(recipe);

        // Assert
        Assert.AreEqual(1, collectionStoringRecipes.Count);
    }

    [Test]
    public void AddingItemsAccordingTheListOfRequiredItemsOfARecipeShouldCombineTheRecipeIntoANewCommonItem()
    {
        // Arrange
        List<string> requiredItems = new List<string>(new string[] { "f", "s", "t" });
        IRecipe recipe = new RecipeItem("recipe", 45, 86, 26, 34, 75, requiredItems);
        IItem firstItem = new CommonItem("f", 10, 15, 13, 12, 14);
        IItem secondfirstItem = new CommonItem("s", 11, 14, 12, 13, 15);
        IItem thirdItem = new CommonItem("t", 13, 12, 15, 14, 10);
        IDictionary<string, IItem> collectionStoringItems = (IDictionary<string, IItem>)this.sut
            .GetType()
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(f => f.Name.Equals($"{nameof(CommonItem)}s", StringComparison.OrdinalIgnoreCase))
            .GetValue(this.sut);

        // Act 
        this.sut.AddRecipeItem(recipe);
        this.sut.AddCommonItem(firstItem);
        this.sut.AddCommonItem(secondfirstItem);
        this.sut.AddCommonItem(thirdItem);

        // Assert
        Assert.AreEqual(1, collectionStoringItems.Count, "The only common item in the collection have to be the transformed recipe. When combining items into recipe - they have to disapear and the recipe to be transformed into a common item");
        Assert.AreEqual(recipe.Name, collectionStoringItems.First().Key, "The only common item in the collection have to be the transformed recipe. When combining items into recipe - they have to disapear and the recipe to be transformed into a common item");
    }

    [Test]
    public void AddingRecipeWithRequiredItemsAlreadyAvailableInTheInventoryShouldAutomaticallyTransformItToANewCommonItem()
    {
        // Arrange
        List<string> requiredItems = new List<string>(new string[] { "f", "s", "t" });
        IRecipe recipe = new RecipeItem("recipe", 45, 86, 26, 34, 75, requiredItems);
        IItem firstItem = new CommonItem("f", 10, 15, 13, 12, 14);
        IItem secondfirstItem = new CommonItem("s", 11, 14, 12, 13, 15);
        IItem thirdItem = new CommonItem("t", 13, 12, 15, 14, 10);
        IDictionary<string, IItem> collectionStoringItems = (IDictionary<string, IItem>)this.sut
            .GetType()
            .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .First(f => f.Name.Equals($"{nameof(CommonItem)}s", StringComparison.OrdinalIgnoreCase))
            .GetValue(this.sut);

        // Act 
        this.sut.AddCommonItem(firstItem);
        this.sut.AddCommonItem(secondfirstItem);
        this.sut.AddCommonItem(thirdItem);
        this.sut.AddRecipeItem(recipe);

        // Assert
        Assert.AreEqual(1, collectionStoringItems.Count, "The only common item in the collection have to be the transformed recipe. When combining items into recipe - they have to disapear and the recipe to be transformed into a common item");
        Assert.AreEqual(recipe.Name, collectionStoringItems.First().Key, "The only common item in the collection have to be the transformed recipe. When combining items into recipe - they have to disapear and the recipe to be transformed into a common item");
    }


    [Test]
    public void StrengthBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(1, this.sut.TotalStrengthBonus);
    }

    [Test]
    public void AgilityBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(2, this.sut.TotalAgilityBonus);
    }

    [Test]
    public void IntelligenceBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(3, this.sut.TotalIntelligenceBonus);
    }

    [Test]
    public void HitPointsBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(4, this.sut.TotalHitPointsBonus);
    }

    [Test]
    public void DamageBonusFromItems()
    {
        CommonItem item = new CommonItem("item", 1, 2, 3, 4, 5);

        this.sut.AddCommonItem(item);

        Assert.AreEqual(5, this.sut.TotalDamageBonus);
    }
}
