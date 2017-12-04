namespace ProductsShop.App
{
    using ProductsShop.Models;
    using System.Collections.Generic;

    public class CategoryProductsComparer : IEqualityComparer<CategoriesProducts>
    {
        public bool Equals(CategoriesProducts x, CategoriesProducts y)
            => $"{x.Category.Name}{x.Product.Name}".Equals($"{y.Category.Name}{y.Product.Name}");

        public int GetHashCode(CategoriesProducts obj)
            => obj.ToString().GetHashCode();
    }
}
