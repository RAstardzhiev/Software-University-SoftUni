namespace _11.Inferno_Infinity.Interfaces
{
    using Enums;

    public interface IGem
    {
        GemClarity Clarity { get; }

        int AgilityBonus { get; }

        int StrengthBonus { get; }

        int VitalityBonus { get; }
    }
}
