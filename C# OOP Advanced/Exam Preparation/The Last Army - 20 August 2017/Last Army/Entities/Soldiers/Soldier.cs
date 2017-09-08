using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private double endurance;

    public Soldier(string name, int age, double experience, double endurance)
    {
        Name = name;
        Age = age;
        Experience = experience;
        Endurance = endurance;
    }

    public string Name { get; private set; }

    public int Age { get; private set; }

    public double Experience { get; private set; }

    public double Endurance
    {
        get
        {
            return this.endurance;
        }

        protected set
        {
            if (value > 100)
            {
                value = 100;
            }

            this.endurance = value;
        }
    }

    public IDictionary<string, IAmmunition> Weapons { get; protected set; }

    public abstract double OverallSkill { get; }

    public abstract void Regenerate();

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        if (this.Weapons.Any(w => w.Value == null || w.Value.WearLevel <= 0))
        {
            return false;
        }

        if (this.Weapons.Any(w => w.Value.WearLevel < 1))
        {
            return false;
        }

        return true;
    }

    private void AmmunitionRevision(double missionWearLevelDecrement)
    {
        foreach (var weapon in this.Weapons)
        {
            weapon.Value.DecreaseWearLevel(missionWearLevelDecrement);
        }
    }

    public void CompleteMission(IMission mission)
    {
        this.Experience += mission.EnduranceRequired;
        this.AmmunitionRevision(mission.WearLevelDecrement);
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.OverallSkill}";
    }
}