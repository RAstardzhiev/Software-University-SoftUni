namespace _11.Inferno_Infinity.Models.Gems
{
    using Enums;
    using Interfaces;

    public abstract class Gem : IGem
    {
        protected Gem(GemClarity clarity, int agilityBonus, int strengthBonus, int vitalityBonus)
        {
            this.Clarity = clarity;
            this.AgilityBonus = agilityBonus + (int)clarity;
            this.StrengthBonus = strengthBonus + (int)clarity;
            this.VitalityBonus = vitalityBonus + (int)clarity;
        }

        public GemClarity Clarity { get; private set; }

        public int AgilityBonus { get; private set; }

        public int StrengthBonus { get; private set; }

        public int VitalityBonus { get; private set; }
    }
}
