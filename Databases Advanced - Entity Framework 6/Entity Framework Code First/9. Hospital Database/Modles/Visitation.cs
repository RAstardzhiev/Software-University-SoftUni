namespace _9.Hospital_Database.Modles
{
    using _9.Hospital_Database.Modles.Helpers;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Visitation
    {
        private string comments;
        private int doctorId;
        private int patientId;
        private int? diagnoseId;

        private DataValidator validator;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitation(int doctorId, string comments, DateTime date, int diagnoseId)
            : this(doctorId, comments, date)
        {
            this.DiagnoseId = diagnoseId;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitation(int doctorId, string comments, int diagnoseId)
            : this(doctorId, comments)
        {
            this.DiagnoseId = diagnoseId;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitation(int doctorId, string comments)
            : this(doctorId, comments, DateTime.Now)
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Visitation(int doctorId, string comments, DateTime date)
        {
            this.DoctorId = doctorId;
            this.Comments = comments;
            this.Date = date;
            this.validator = new DataValidator();
        }

        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(255)]
        public string Comments
        {
            get
            {
                return this.comments;
            }

            set
            {
                this.validator.NullCheck(value);
                this.comments = value;
            }
        }

        public int? DiagnoseId
        {
            get
            {
                return this.diagnoseId;
            }

            set
            {
                this.validator.IdValidation(value);
                this.diagnoseId = value;
            }
        }

        [Required]
        public int PatientId
        {
            get
            {
                return this.patientId;
            }

            set
            {
                this.validator.IdValidation(value);
                this.patientId = value;
            }
        }

        [Required]
        public int DoctorId
        {
            get
            {
                return this.doctorId;
            }

            set
            {
                this.validator.IdValidation(value);
                this.doctorId = value;
            }
        }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Diagnose Diagnose { get; set; }
    }
}
