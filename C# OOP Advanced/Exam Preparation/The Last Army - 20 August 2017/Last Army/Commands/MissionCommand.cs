using System;
using System.Collections.Generic;

public class MissionCommand : Command
{
    public MissionCommand(IList<string> cmdArgs, IGameController gamecontroller) 
        : base(cmdArgs, gamecontroller)
    {
    }

    public override void Execute()
    {
        var type = this.CmdArgs[0];
        var scoreToComplete = double.Parse(this.CmdArgs[1]);

        var mission = this.GameController.MissionFactory.CreateMission(type, scoreToComplete);
        var resultMessage = this.GameController.MissionControllerProp.PerformMission(mission);

        throw new ArgumentException(resultMessage);
    }
}
