namespace Avatar___12_July_2017.Models.Monuments
{
    public class WaterMonument : Monument
    {
        private int waterAffinity;

        public WaterMonument(string name, int waterAffinity) : base(name)
        {
            this.waterAffinity = waterAffinity;
        }

        public override int GetAffinity()
        {
            return this.waterAffinity;
        }

        public override string ToString()
        {
            return $"{this.Name}, Water Affinity: {this.waterAffinity}";
        }
    }
}
