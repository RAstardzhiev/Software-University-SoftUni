namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Models;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {
        private Course()
        {
            this.Students = new HashSet<Student>();
            this.Resources = new HashSet<Resource>();
            this.Homeworks = new HashSet<Homework>();
        }

        public Course(string name, DateTime startDate, DateTime endDate, decimal price)
            : this()
        {
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Price = price;
        }

        public int Id { get; set; }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime? StartDate { get; set; }

        [Required]
        public DateTime? EndDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
