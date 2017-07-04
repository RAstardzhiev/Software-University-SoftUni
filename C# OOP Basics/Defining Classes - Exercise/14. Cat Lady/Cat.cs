namespace _14.Cat_Lady
{
    public class Cat
    {
        private string name;
        private string breed;
        private double characteristicValue;

        public Cat(string name, string breed, double characteristicValue)
        {
            this.name = name;
            this.breed = breed;
            this.characteristicValue = characteristicValue;
        }

        public string Name { get { return this.name; } }

        public override string ToString()
        {
            if (this.breed == "Cymric")
            {
                return $"{this.breed} {this.name} {this.characteristicValue:F2}";
            }
            else
            {
                return $"{this.breed} {this.name} {(int)this.characteristicValue}";
            }
        }
    }
}
