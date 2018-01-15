namespace Photos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Photographer
    {
        private Photographer()
        {
            this.Albums = new HashSet<Album>();
        }

        public Photographer(string userName, string password, string email)
            : this()
        {
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string UserName { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(16)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public DateTime? RegisterDate { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
