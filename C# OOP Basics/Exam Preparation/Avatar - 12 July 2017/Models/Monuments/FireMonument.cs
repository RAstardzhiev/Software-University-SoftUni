namespace Avatar___12_July_2017.Models.Monuments
{
    public class FireMonument : Monument
    {
        private int fireAffinity;

        public FireMonument(string name, int fireAffinity) : base(name)
        {
            this.fireAffinity = fireAffinity;
        }

        public override int GetAffinity()
        {
            return this.fireAffinity;
        }

        public override string ToString()
        {
            return $"{this.Name}, Fire Affinity: {this.fireAffinity}";
        }
    }
}
