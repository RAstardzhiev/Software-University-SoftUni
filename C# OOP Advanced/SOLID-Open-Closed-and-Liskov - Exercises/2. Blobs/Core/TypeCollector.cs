namespace _02.Blobs.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class TypeCollector : ITypesCollector
    {
        public Type[] GetAbstractionsAllChildrent<T>() where T : class
        {
            var parentType = typeof(T);
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => parentType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .ToArray();
        }
    }
}
