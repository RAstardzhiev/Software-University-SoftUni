using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Stations.DataProcessor.Dto.Import.Ticket
{
    [XmlType("Card")]
    public class CardDto
    {
        [Required]
        [XmlAttribute("Name")]
        public string Name { get; set; }
    }
}
