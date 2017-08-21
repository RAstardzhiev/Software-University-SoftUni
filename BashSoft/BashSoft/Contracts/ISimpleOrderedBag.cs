namespace BashSoft.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ISimpleOrderedBag<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        int Size { get; }

        int Capacity { get; }

        T this[int index] { get; }

        bool Remove(T element);

        void Add(T element);

        void AddAll(ICollection<T> collection);

        string JoinWith(string joiner);
    }
}
