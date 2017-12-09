using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Stations.DataProcessor.Dto.Import.Ticket
{
    [XmlType("Ticket")]
    public class TicketDto
    {
        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        [XmlAttribute("price")]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{2}\d{1,6}$")]
        [XmlAttribute("seat")]
        public string Seat { get; set; }

        [Required]
        public Ticket.TripDto Trip { get; set; }

        public Ticket.CardDto Card { get; set; }
    }
}
