namespace _02.Blobs.Interfaces
{
    using System;

    public interface ITypesCollector
    {
        Type[] GetAbstractionsAllChildrent<T>()
            where T : class;
    }
}
