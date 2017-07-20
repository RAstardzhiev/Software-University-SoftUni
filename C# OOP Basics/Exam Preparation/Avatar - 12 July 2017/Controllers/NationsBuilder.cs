namespace Avatar___12_July_2017.Controllers
{
    using Models;
    using Models.Benders;
    using Models.Monuments;
    using System.Collections.Generic;
    using System.Linq;

    public class NationsBuilder
    {
        private Nation airNation;
        private Nation waterNation;
        private Nation fireNation;
        private Nation earthNation;
        private WarStat warStat;

        public NationsBuilder()
        {
            this.airNation = new Nation("Air");
            this.waterNation = new Nation("Water");
            this.fireNation = new Nation("Fire");
            this.earthNation = new Nation("Earth");
            this.warStat = new WarStat();
        }

        public void AssignBender(List<string> benderArgs)
        {
            var type = benderArgs[0];
            var name = benderArgs[1];
            var power = int.Parse(benderArgs[2]);
            var secondaryParam = double.Parse(benderArgs[3]);

            switch (type)
            {
                case "Air":
                    this.airNation.AddBender(new AirBender(name, power, secondaryParam));
                    break;
                case "Water":
                    this.waterNation.AddBender(new WaterBender(name, power, secondaryParam));
                    break;
                case "Fire":
                    this.fireNation.AddBender(new FireBender(name, power, secondaryParam));
                    break;
                case "Earth":
                    this.earthNation.AddBender(new EarthBender(name, power, secondaryParam));
                    break;
                default:
                    break;
            }
        }

        public void AssignMonument(List<string> monumentArgs)
        {
            var type = monumentArgs[0];
            var name = monumentArgs[1];
            var affinity = int.Parse(monumentArgs[2]);

            switch (type)
            {
                case "Air":
                    this.airNation.AddMonument(new AirMonument(name, affinity));
                    break;
                case "Water":
                    this.waterNation.AddMonument(new WaterMonument(name, affinity));
                    break;
                case "Fire":
                    this.fireNation.AddMonument(new FireMonument(name, affinity));
                    break;
                case "Earth":
                    this.earthNation.AddMonument(new EarthMonument(name, affinity));
                    break;
                default:
                    break;
            }
        }

        public string GetStatus(string nationsType)
        {
            if (nationsType == "Air")
            {
                return this.airNation.ToString();
            }

            if (nationsType == "Water")
            {
                return this.waterNation.ToString();
            }

            if (nationsType == "Fire")
            {
                return this.fireNation.ToString();
            }

            if (nationsType == "Earth")
            {
                return this.earthNation.ToString();
            }

            return string.Empty;
        }

        public void IssueWar(string nationsType)
        {
            this.warStat.AddNewWar(nationsType);
            var nations = new Nation[] { this.airNation, this.waterNation, this.fireNation, this.earthNation };

            foreach (var looser in nations.OrderByDescending(n => n.GetTotalPower()).Skip(1))
            {
                looser.RemoveResources();
            }
        }

        public string GetWarsRecord()
        {
            return this.warStat.ToString();
        }
    }
}
