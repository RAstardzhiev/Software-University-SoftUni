using FastFood.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import
{
    [XmlType("Order")]
    public class OrderDto
    {
        [Required]
        public string Customer { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [XmlElement("Employee")]
        public string EmployeeName { get; set; }

        [Required]
        public string DateTime { get; set; }

        public OrderType Type { get; set; } = OrderType.ForHere;

        public OrderItemDto[] Items { get; set; }
    }
}
