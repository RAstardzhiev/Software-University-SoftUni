namespace ProductsShop.App.Exports
{
    using Newtonsoft.Json;
    using ProductsShop.App.Interfaces;
    using System.IO;

    public class JsonExporter : IExporter
    {
        public void Export<TModel>(string filePath, TModel[] collection)
        {
            var jsonString = JsonConvert.SerializeObject(collection, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public void Export<TModel>(string filePath, TModel model)
        {
            var jsonString = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
