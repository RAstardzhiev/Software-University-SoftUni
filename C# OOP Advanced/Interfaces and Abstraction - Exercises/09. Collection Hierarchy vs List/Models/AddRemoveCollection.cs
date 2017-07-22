namespace _09.Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Linq;

    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        private const int IndexForAddingNewElement = 0;

        public virtual T Remove()
        {
            var lastElement = this.Data.Last();
            this.Data.RemoveAt(this.Data.Count - 1);
            return lastElement;
        }

        public override int Add(T element)
        {
            this.Data.Insert(IndexForAddingNewElement, element);
            return IndexForAddingNewElement;
        }
    }
}
