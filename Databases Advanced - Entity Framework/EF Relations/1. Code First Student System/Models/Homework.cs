namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        private Homework()
        {
        }

        public Homework(string contentPath, string contentType, DateTime submissionDate, Student student)
        {
            this.ContentPath = contentPath;
            this.ContentType = contentType;
            this.SubmissionDate = submissionDate;
            this.Student = student;
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string ContentPath { get; set; }

        [Required]
        [StringLength(25)]
        public string ContentType { get; set; }

        [Required]
        public DateTime? SubmissionDate { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
