using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Dtos.Import
{
    [XmlType("comment")]
    public class CommentDto
    {
        [Required]
        [MaxLength(250)]
        [XmlElement("content")]
        public string Content { get; set; }

        [Required]
        [XmlElement("user")]
        public string Username { get; set; }

        [Required]
        [XmlElement("post")]
        public CommentPostDto Post { get; set; }
    }
}
