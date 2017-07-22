namespace _09.Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Linq;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private const int IndexForAddingNewElement = 0;

        public virtual T Remove()
        {
            return this.Data.Pop();
        }

        public override int Add(T element)
        {
            this.Data = new Stack<T>(new T[] { element }.Concat(this.Data.Reverse()));
            return IndexForAddingNewElement;
        }
    }
}
