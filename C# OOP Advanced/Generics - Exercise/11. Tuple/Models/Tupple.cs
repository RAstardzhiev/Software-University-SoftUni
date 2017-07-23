namespace _11.Tuple.Models
{
    public class Tupple<T1, T2>
    {
        private T1 first;
        private T2 second;

        public Tupple(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }

        public override string ToString()
        {
            return $"{this.first.ToString()} -> {this.second.ToString()}";
        }
    }
}
