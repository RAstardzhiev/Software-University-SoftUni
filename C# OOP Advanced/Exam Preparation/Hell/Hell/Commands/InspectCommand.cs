using System.Collections.Generic;
using System.Linq;

public class InspectCommand : AbstractCommand
{
    public InspectCommand(IList<string> args, IHeroManager heroManager) 
        : base(args, heroManager)
    {
    }

    public override string Execute() => this.HeroManager.Inspect(this.ArgsList.ToList());
}
