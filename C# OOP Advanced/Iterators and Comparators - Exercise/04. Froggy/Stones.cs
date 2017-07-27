namespace _04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Stones<T> : IEnumerable<T>
    {
        private T[] stonesCollection;

        public Stones(IEnumerable<T> numbers)
        {
            this.stonesCollection = numbers.ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stonesCollection.Length; i += 2)
            {
                yield return this.stonesCollection[i];
            }

            var lastOddIndex = this.stonesCollection.Length % 2 == 0
                ? this.stonesCollection.Length - 1
                : this.stonesCollection.Length - 2;

            for (int i = lastOddIndex; i >= 0; i -= 2)
            {
                    yield return this.stonesCollection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
