using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Instagraph.DataProcessor.Dtos.Import
{
    [XmlType("post")]
    public class PostDto
    {
        [Required]
        [XmlElement("caption")]
        public string Caption { get; set; }

        [Required]
        [XmlElement("user")]
        public string Username { get; set; }

        [Required]
        [XmlElement("picture")]
        public string PicturePath { get; set; }
    }
}
