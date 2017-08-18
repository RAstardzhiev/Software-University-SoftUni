using System.Collections.Generic;

public abstract class AbstractCommand : ICommand
{
    private IList<string> argsList;
    private IHeroManager heroManager;

    public AbstractCommand(IList<string> args, IHeroManager heroManager)
    {
        this.argsList = args;
        this.heroManager = heroManager;
    }

    public IReadOnlyList<string> ArgsList => this.argsList as IReadOnlyList<string>;

    public IHeroManager HeroManager => this.heroManager;

    public abstract string Execute();
}
