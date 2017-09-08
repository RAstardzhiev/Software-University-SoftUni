using System.Collections.Generic;

public class SoldierRegenerateCommand : Command
{
    public SoldierRegenerateCommand(IList<string> cmdArgs, IGameController gamecontroller) 
        : base(cmdArgs, gamecontroller)
    {
    }

    public override void Execute()
    {
        var soldierType = this.CmdArgs[0];
        this.GameController.RegenerateSoldiers(soldierType);
    }
}
