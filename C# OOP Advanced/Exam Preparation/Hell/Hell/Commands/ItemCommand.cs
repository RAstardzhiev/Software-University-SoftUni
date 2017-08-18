using System.Collections.Generic;
using System.Linq;

public class ItemCommand : AbstractCommand
{
    public ItemCommand(IList<string> args, IHeroManager heroManager) 
        : base(args, heroManager)
    {
    }

    public override string Execute() => this.HeroManager.AddItemToHero(this.ArgsList.ToList());
}
