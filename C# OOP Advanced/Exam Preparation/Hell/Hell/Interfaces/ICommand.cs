using System.Collections.Generic;

public interface ICommand
{
    IReadOnlyList<string> ArgsList { get; }

    IHeroManager HeroManager { get; }

    string Execute();
}
