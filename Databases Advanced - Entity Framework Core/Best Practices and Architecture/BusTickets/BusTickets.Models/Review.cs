namespace BusTickets.Models
{
    using System;

    public class Review
    {
        public const byte MinGrade = 1;
        public const byte MaxGrade = 10;

        private readonly string InvalidGradeExceptionMessage = $"Grade must be number in range [{MinGrade}, {MaxGrade}].";

        private double grade;

        private Review()
        {
        }

        public Review(string content, double grade, DateTime publishDate, BusCompany busCompany, Customer customer)
        {
            this.Content = content;
            this.Grade = grade;
            this.PublishDate = publishDate;
            this.BusCompany = busCompany;
            this.Customer = customer;
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public double Grade
        {
            get => this.grade;

            set
            {
                if (value < MinGrade || value > MaxGrade)
                {
                    throw new ArgumentException(InvalidGradeExceptionMessage);
                }

                this.grade = value;
            }
        }

        public DateTime PublishDate { get; set; }

        public int BusCompanyId { get; set; }
        public BusCompany BusCompany { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
