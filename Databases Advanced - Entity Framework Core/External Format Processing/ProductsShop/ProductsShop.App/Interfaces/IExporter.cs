namespace ProductsShop.App.Interfaces
{
    public interface IExporter
    {
        void Export<TModel>(string filePath, TModel[] collection);

        void Export<TModel>(string filePath, TModel model);
    }
}
