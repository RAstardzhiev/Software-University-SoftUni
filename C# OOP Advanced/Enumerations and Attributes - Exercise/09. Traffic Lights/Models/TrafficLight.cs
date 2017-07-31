namespace _09.Traffic_Lights.Models
{
    using System;
    using Enums;

    public class TrafficLight
    {
        private readonly int lightsCount;

        public TrafficLight(LightColor light)
        {
            this.Light = light;
            this.lightsCount = Enum.GetNames(typeof(LightColor)).Length;
        }

        public LightColor Light { get; private set; }

        public void ChangeLight()
        {
            var nextValue = (int)this.Light + 1;
            if (nextValue == this.lightsCount)
            {
                nextValue = 0;
            }

            var nextLight = (LightColor)nextValue;
            this.Light = nextLight;
        }
    }
}
