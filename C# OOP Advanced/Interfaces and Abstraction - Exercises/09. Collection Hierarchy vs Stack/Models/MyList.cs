namespace _09.Collection_Hierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;
    using System.Linq;

    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public IReadOnlyCollection<T> Used
        {
            get
            {
                return this.Data as IReadOnlyCollection<T>;
            }
        }

        public override T Remove()
        {
            var firstElemennt = this.Data.Last();
            this.Data = new Stack<T>(this.Data.Take(this.Data.Count - 1).Reverse());
            return firstElemennt;
        }
    }
}
