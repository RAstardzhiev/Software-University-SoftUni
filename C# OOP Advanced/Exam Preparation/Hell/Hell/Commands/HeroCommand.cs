using System.Collections.Generic;
using System.Linq;

public class HeroCommand : AbstractCommand
{
    public HeroCommand(IList<string> args, IHeroManager heroManager) 
        : base(args, heroManager)
    {
    }

    public override string Execute() => this.HeroManager.AddHero(this.ArgsList.ToList());
}
