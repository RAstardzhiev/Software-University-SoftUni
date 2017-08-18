using System.Collections.Generic;
using System.Linq;

public class RecipeCommand : AbstractCommand
{
    public RecipeCommand(IList<string> args, IHeroManager heroManager) 
        : base(args, heroManager)
    {
    }

    public override string Execute() => this.HeroManager.AddRecipeToHero(this.ArgsList.ToArray());
}
