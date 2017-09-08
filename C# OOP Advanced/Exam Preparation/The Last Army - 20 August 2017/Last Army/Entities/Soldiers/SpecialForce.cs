using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    private const int RegenerationEnduranceIncreasement = 30;

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
        this.Weapons = new Dictionary<string, IAmmunition>()
            {
                { "Gun", null },
                { "AutomaticMachine", null },
                { "MachineGun", null },
                { "RPG", null },
                { "Helmet", null },
                { "Knife", null },
                { "NightVision", null }
            };
    }

    public override double OverallSkill => (this.Age + this.Experience) * OverallSkillMiltiplier;

    public override void Regenerate() => this.Endurance += (RegenerationEnduranceIncreasement + this.Age);
}