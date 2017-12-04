namespace ProductsShop.App.Imports
{
    using ProductsShop.Data;

    public class XmlImporter : Importer
    {
        public XmlImporter(ProductsShopContext context) 
            : base(context)
        {
        }

        public override void Import()
        {
            throw new System.NotImplementedException();
        }

        protected override TModel[] DeserializeJson<TModel>(string filePath)
        {
            throw new System.NotImplementedException();
        }
    }
}
