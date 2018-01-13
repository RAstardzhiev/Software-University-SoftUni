using System;
using System.Collections.Generic;
using System.Linq;

namespace PetClinic.Models
{
    public class Procedure
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public decimal Cost => this.ProcedureAnimalAids
            .Select(paa => paa.AnimalAid.Price)
            .Sum(); // calculated by summing the price of the different services performed

        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

        public int VetId { get; set; }
        public Vet Vet { get; set; }

        public ICollection<ProcedureAnimalAid> ProcedureAnimalAids { get; set; } = new HashSet<ProcedureAnimalAid>();
    }
}