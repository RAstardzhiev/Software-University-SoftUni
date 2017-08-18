using System;
using System.Linq;
using System.Reflection;

public class TypeCollector : ITypeCollector
{
    private const string InvalidAbstractionTypeExceptionMessage = "Provided class {0} is neither Abstract nor Interface";

    public Type[] GetAllInheritingTypes<T>() 
        where T : class
    {
        Type parentType = typeof(T);
        if (!parentType.IsAbstract && !parentType.IsInterface)
        {
            throw new ArgumentException(string.Format(InvalidAbstractionTypeExceptionMessage, parentType.Name));
        }

        return Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => parentType.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .ToArray();
    }
}
