namespace P01_HospitalDatabase.Data.Models
{
    using System.Collections.Generic;

    public class Doctor
    {
        public Doctor()
        {
            this.Visitations = new HashSet<Visitation>();
        }

        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Specialty { get; set; }

        public ICollection<Visitation> Visitations { get; set; }
    }
}
