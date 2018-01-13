namespace PetClinic.Models
{
    public class ProcedureAnimalAid
    {
        public int ProcedureId { get; set; }
        public Procedure Procedure { get; set; }

        public int AnimalAidId { get; set; }
        public AnimalAid AnimalAid { get; set; }
    }
}
