namespace RandomDataGenerator
{
    using System;
    using System.Text;

    public class DataGenerator
    {
        public const int FloatDivisor = 3;
        private const int LowerCaseFirstLetter = 'a';
        private const int LowerCaseLastLetter = 'z';
        private const int UpperCaseFirstLetter = 'A';
        private const int UpperCaseLastLetter = 'Z';
        private readonly string[] NumbersAsString = new[] 
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
        };

        public DataGenerator()
        {
            this.Random = new Random();
        }

        public Random Random { get; set; }

        public string GenerateString(int minLength = 3, int maxLength = 10)
        {
            if (minLength > maxLength)
            {
                return this.GenerateString(maxLength, minLength);
            }

            minLength--;
            var length = this.Random.Next(minLength, maxLength);
            var sb = new StringBuilder();

            // Putting the first letter to be UpperCase
            sb.Append((char)this.Random.Next(UpperCaseFirstLetter, UpperCaseLastLetter + 1));

            for (int i = 0; i < length; i++)
            {
                var ch = (char)this.Random.Next(LowerCaseFirstLetter, LowerCaseLastLetter + 1);
                sb.Append(ch);
            }

            return sb.ToString();
        }

        public string GenerateNumberAndLettersString(int minLength = 3, int maxLength = 10)
        {
            if (minLength > maxLength)
            {
                return this.GenerateNumberAndLettersString(maxLength, minLength);
            }

            var length = this.Random.Next(minLength, maxLength + 1);
            var sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                var isletter = this.Random.Next() % 2 == 0;
                if (isletter)
                {
                    sb.Append((char)this.Random.Next(UpperCaseFirstLetter, UpperCaseLastLetter + 1));
                }
                else
                {
                    sb.Append(this.GetElementFromSequence(NumbersAsString));
                }
            }

            return sb.ToString();
        }

        public DateTime GenerateDate(DateTime? minDate = null) => minDate == null
            ? this.Random.Next() % 2 == 0
                ? DateTime.Now.AddDays(this.Random.Next(1, 10))
                : DateTime.Now.AddDays(this.Random.Next(1, 10) * -1)
            : minDate.Value.AddDays(this.Random.Next(1, 10));

        public TElement GetElementFromSequence<TElement>(TElement[] sequence)
        => sequence[this.Random.Next(sequence.Length)];

        public int GenerateInteger(int minValue = 1, int maxValue = int.MaxValue)
            => this.Random.Next(minValue, maxValue);

        public double GenerateDouble(int minValue = 1, int maxValue = int.MaxValue)
            => this.Random.Next(minValue, maxValue) / FloatDivisor;

        public decimal GenerateDecimal(int minValue = 1, int maxValue = int.MaxValue)
            => (decimal)this.GenerateDouble();
    }
}
