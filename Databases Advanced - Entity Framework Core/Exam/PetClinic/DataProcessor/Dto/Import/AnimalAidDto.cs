using System.ComponentModel.DataAnnotations;

namespace PetClinic.DataProcessor.Dto.Import
{
    public class AnimalAidDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue)] // Judge Range Test
        public decimal Price { get; set; }
    }
}
