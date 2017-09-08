using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Mission : IMission
{
    public Mission(string name, double enduranceRequired, double scoreToComplete, double wearLevelDecrement)
    {
        Name = name;
        EnduranceRequired = enduranceRequired;
        ScoreToComplete = scoreToComplete;
        WearLevelDecrement = wearLevelDecrement;
    }

    public string Name { get; private set; }

    public double EnduranceRequired { get; private set; }

    public double ScoreToComplete { get; private set; }

    public double WearLevelDecrement { get; private set; }
}
