using System;
using System.Collections.Generic;

public class Corporal : Soldier
{
    private const double OverallSkillMiltiplier = 2.5;
    private const int RegenerationEnduranceIncreasement = 10;

    public Corporal(string name, int age, double experience, double endurance) 
        : base(name, age, experience, endurance)
    {
        this.Weapons = new Dictionary<string, IAmmunition>()
        {
            { "Gun", null },
            { "AutomaticMachine", null },
            { "MachineGun", null },
            { "Helmet", null },
            { "Knife", null }
        };
    }

    public override double OverallSkill => (this.Age + this.Experience) * OverallSkillMiltiplier;

    public override void Regenerate() => this.Endurance += (RegenerationEnduranceIncreasement + this.Age);
}
