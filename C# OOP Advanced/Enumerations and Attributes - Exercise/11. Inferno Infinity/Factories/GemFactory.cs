namespace _11.Inferno_Infinity.Factories
{
    using System;
    using Enums;
    using Interfaces;
    using Models.Gems;

    public class GemFactory
    {
        public IGem CreateGem(string kind, string clarity)
        {
            GemClarity gemClarity;
            var isGemValid = Enum.TryParse(clarity, out gemClarity);

            if (!isGemValid)
            {
                return null;
            }

            switch (kind)
            {
                case "Ruby":
                    return new Ruby(gemClarity);
                case "Emerald":
                    return new Emerald(gemClarity);
                case "Amethyst":
                    return new Amethyst(gemClarity);
                default:
                    return null;
            }
        }
    }
}
