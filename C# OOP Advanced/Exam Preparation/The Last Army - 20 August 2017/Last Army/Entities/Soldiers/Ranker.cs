using System;
using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;
    private const int RegenerationEnduranceIncreasement = 10;

    public Ranker(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        this.Weapons = new Dictionary<string, IAmmunition>()
        {
            { "Gun", null },
            { "AutomaticMachine", null },
            { "Helmet", null }
        };
    }

    public override double OverallSkill => (this.Age + this.Experience) * OverallSkillMiltiplier;

    public override void Regenerate() => this.Endurance += (RegenerationEnduranceIncreasement + this.Age);
}
