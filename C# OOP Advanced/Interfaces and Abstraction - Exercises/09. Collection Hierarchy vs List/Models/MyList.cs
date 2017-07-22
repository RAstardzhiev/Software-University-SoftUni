namespace _09.Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        private const int RemovalIndex = 0;

        public IReadOnlyCollection<T> Used
        {
            get
            {
                return this.Data as IReadOnlyCollection<T>;
            }
        }

        public override T Remove()
        {
            var firstElemennt = this.Data.First();
            this.Data.RemoveAt(RemovalIndex);
            return firstElemennt;
        }
    }
}
