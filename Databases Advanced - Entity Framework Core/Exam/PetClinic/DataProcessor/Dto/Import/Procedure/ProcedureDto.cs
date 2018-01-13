using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace PetClinic.DataProcessor.Dto.Import.Procedure
{
    [XmlType("Procedure")]
    public class ProcedureDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        [XmlElement("Vet")]
        public string VetName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{7}[0-9]{3}$")]
        [XmlElement("Animal")]
        public string AnimalSerialNumber { get; set; }

        [Required]
        [XmlElement("DateTime")]
        public string ProcedureDate { get; set; }

        public ProcedureAnimalAidDto[] AnimalAids { get; set; }
    }
}
