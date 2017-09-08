using System;
using System.Collections.Generic;

public class SoldierCommand : Command
{
    private const string SoldierNotEquipedExceptionMessage = "There is no weapon for {0} {1}!";

    public SoldierCommand(IList<string> cmdArgs, IGameController gamecontroller) 
        : base(cmdArgs, gamecontroller)
    {
    }

    public override void Execute()
    {
        var type = this.CmdArgs[0];
        var name = this.CmdArgs[1];
        var age = int.Parse(this.CmdArgs[2]);
        var experience = double.Parse(this.CmdArgs[3]);
        var endurance = double.Parse(this.CmdArgs[4]);

        var soldier = this.GameController.SoldierFactory.CreateSoldier(type, name, age, experience, endurance);
        this.GameController.WearHouse.TryEquipSoldier(soldier);

        if (!this.GameController.WearHouse.TryEquipSoldier(soldier))
        {
            throw new ArgumentException(string.Format(SoldierNotEquipedExceptionMessage, type, name));
        }

        this.GameController.Army.AddSoldier(soldier);
    }
}
