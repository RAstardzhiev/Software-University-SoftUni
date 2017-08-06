namespace _5.Integration_Tests.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IUser
    {
        string Name { get; }

        IEnumerable<ICategory> Categories { get; }

        void AddCategory(ICategory category);

        void RemoveCategory(ICategory category);
    }
}
