namespace _02.Black_Box_Integer
{
    public class BlackBoxInt
    {
        private static int DefaultValue = 0;

        private int innerValue;

        private BlackBoxInt(int innerValue)
        {
            this.innerValue = innerValue;
        }

        private BlackBoxInt()
        {
            this.innerValue = DefaultValue;
        }

        private void Add(int addend)
        {
            this.innerValue += addend;
        }

        private void Subtract(int subtrahend)
        {
            this.innerValue -= subtrahend;
        }

        private void Multiply(int multiplier)
        {
            this.innerValue *= multiplier;
        }

        private void Divide(int divider)
        {
            this.innerValue /= divider;
        }

        private void LeftShift(int shifter)
        {
            this.innerValue <<= shifter;
        }

        private void RightShift(int shifter)
        {
            this.innerValue >>= shifter;
        }
    }
}
