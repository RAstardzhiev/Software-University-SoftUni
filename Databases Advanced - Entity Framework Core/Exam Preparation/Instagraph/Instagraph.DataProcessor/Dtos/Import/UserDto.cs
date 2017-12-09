using System.ComponentModel.DataAnnotations;

namespace Instagraph.DataProcessor.Dtos.Import
{
    public class UserDto
    {
        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MinLength(1)]
        public string ProfilePicture { get; set; }
    }
}
