namespace _09.Collection_Hierarchy.Models
{
    using Interfaces;
    using System.Collections.Generic;

    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Data = new List<T>();
        }

        protected List<T> Data { get; set; }

        public virtual int Add(T element)
        {
            this.Data.Add(element);
            return this.Data.Count - 1;
        }
    }
}
