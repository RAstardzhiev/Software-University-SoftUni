using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    public QuitCommand(IList<string> args, IHeroManager heroManager) 
        : base(args, heroManager)
    {
    }

    public override string Execute() => this.HeroManager.ToString();
}