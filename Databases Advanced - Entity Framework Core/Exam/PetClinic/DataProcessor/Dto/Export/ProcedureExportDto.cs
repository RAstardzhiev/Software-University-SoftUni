using System.Xml.Serialization;

namespace PetClinic.DataProcessor.Dto.Export
{
    [XmlType("Procedure")]
    public class ProcedureExportDto
    {
        public string Passport { get; set; }

        public string OwnerNumber { get; set; }

        public string DateTime { get; set; }

        public ProcedureExportAnimalAidDto[] AnimalAids { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
