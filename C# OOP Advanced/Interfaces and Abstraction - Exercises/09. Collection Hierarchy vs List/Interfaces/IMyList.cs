namespace _09.Collection_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
