using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Export
{
    [XmlType("Category")]
    public class CategoryStatDto
    {
        public string Name { get; set; }

        public MostPopularItem MostPopularItem { get; set; }
    }
}
