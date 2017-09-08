using System.Collections.Generic;

public abstract class Command : ICommand
{
    public Command(IList<string> cmdArgs, IGameController gamecontroller)
    {
        this.CmdArgs = cmdArgs;
        this.GameController = gamecontroller;
    }

    protected IList<string> CmdArgs { get; private set; }

    protected IGameController GameController { get; private set; }

    public abstract void Execute();
}
