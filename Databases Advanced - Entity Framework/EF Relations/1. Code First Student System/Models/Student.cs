namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        private Student()
        {
            this.Cources = new HashSet<Course>();
        }

        public Student(string name, DateTime registrationDate)
            : this()
        {
            this.Name = name;
            this.RegistrationDate = registrationDate;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index("IX_Name_phoneNumber", 1, IsUnique = true)]
        public string Name { get; set; }

        [MinLength(10)]
        [MaxLength(20)]
        [Index("IX_Name_phoneNumber", 2, IsUnique = true)]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime? RegistrationDate { get; private set; }

        public DateTime? Birthday { get; set; }

        public virtual ICollection<Course> Cources { get; set; }
    }
}
