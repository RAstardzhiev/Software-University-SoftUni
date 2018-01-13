using System.Xml.Serialization;

namespace PetClinic.DataProcessor.Dto.Export
{
    [XmlType("AnimalAid")]
    public class ProcedureExportAnimalAidDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
