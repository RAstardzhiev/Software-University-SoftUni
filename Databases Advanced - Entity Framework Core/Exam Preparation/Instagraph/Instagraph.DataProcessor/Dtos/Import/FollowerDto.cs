using System.ComponentModel.DataAnnotations;

namespace Instagraph.DataProcessor.Dtos.Import
{
    public class FollowerDto
    {
        [Required]
        public string User { get; set; }

        [Required]
        public string Follower { get; set; }
    }
}
