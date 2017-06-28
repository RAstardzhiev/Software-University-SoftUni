namespace _08.Raw_Data
{
    public class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }

        public int Speed
        {
            get { return this.speed; }
        }

        public int Power
        {
            get { return this.power; }
        }
    }
}
