using System.ComponentModel.DataAnnotations;

namespace Instagraph.DataProcessor.Dtos.Import
{
    public class PictureDto
    {
        [Required]
        [MinLength(1)]
        public string Path { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public decimal Size { get; set; }
    }
}
