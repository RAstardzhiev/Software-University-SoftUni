namespace _5.Integration_Tests.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class User : IUser
    {
        private string name;
        private HashSet<ICategory> categories;

        public User(string name)
        {
            this.name = name;
            this.categories = new HashSet<ICategory>();
        }

        public string Name => this.name;

        public IEnumerable<ICategory> Categories => this.categories as IReadOnlyCollection<ICategory>;

        public void AddCategory(ICategory category) => this.categories.Add(category);

        public void RemoveCategory(ICategory category)
        {
            this.categories.RemoveWhere(c => c.Name == category.Name);

            if (category.Parent != null)
            {
                this.categories.Add(category.Parent);
            }
        }
    }
}
