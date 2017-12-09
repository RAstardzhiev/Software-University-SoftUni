using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Dtos.Import
{
    [XmlType("post")]
    public class CommentPostDto
    {
        [Required]
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
