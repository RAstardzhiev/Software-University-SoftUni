namespace Paw_Inc___25_August_2016.Controllers
{
    using Animals;
    using Centers;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PawIncManager
    {
        private List<AdoptionCenter> adoptionCenters;
        private List<CleansingCenter> cleansingCenters;
        private List<CastrationCenter> castrationCenters;

        public PawIncManager()
        {
            this.adoptionCenters = new List<AdoptionCenter>();
            this.cleansingCenters = new List<CleansingCenter>();
            this.castrationCenters = new List<CastrationCenter>();
        }

        public void Adopt(string adoptionCenterName)
        {
            // All CLEANSED animals from the given Adoption center get adopted, and removed from the stored animals.
            var currentAdoptionCenter = this.adoptionCenters.FirstOrDefault(ac => ac.Name == adoptionCenterName);

            if (currentAdoptionCenter == null)
            {
                return;
            }

            currentAdoptionCenter.AdoptAllCleansedAnimals();
        }

        public void Cleanse(string cleansingCenterName)
        {
            // Cleanses all animals from the given Cleansing center and returns them to their corresponding Adoption centers.
            var currentCleansingCenter = this.cleansingCenters.FirstOrDefault(c => c.Name == cleansingCenterName);

            if (currentCleansingCenter == null)
            {
                return;
            }

            // Return animals to their Adoption Center
            foreach (var client in currentCleansingCenter.ClientNameAndAnimals)
            {
                var currentAdoptionCenter = this.adoptionCenters.First(ac => ac.Name == client.Key);
                currentAdoptionCenter.AddAnimals(client.Value);
            }

            // Update animals status to Cleansed and clear the clients records
            currentCleansingCenter.Cleanse();
        }

        public void Castrate(string name)
        {
            // Castrates all animals from the given Castration center and returns them to their 
            // corresponding Adoption centers
            var currentCastratingCenter = this.castrationCenters.FirstOrDefault(cc => cc.Name == name);

            if (currentCastratingCenter == null)
            {
                return;
            }

            // Return animals to their center
            foreach (var client in currentCastratingCenter.ClientAnimals)
            {
                var currentAdoptionCenter = this.adoptionCenters.First(cc => cc.Name == client.Key);
                currentAdoptionCenter.AddAnimals(client.Value);
            }

            // Update the status odf animals to Castrated and clear the clients records
            currentCastratingCenter.Castrate();
        }

        public void SendForCleansing(string adoptionCenterName, string cleansingCenterName)
        {
            // Sends all UNCLEANSED animals from the given Adoption center to the given Cleansing center.

            // Extract Centers to work with
            var currentAdoptionCenter = this.adoptionCenters.FirstOrDefault(c => c.Name == adoptionCenterName);
            var currentCleansingCenter = this.cleansingCenters.FirstOrDefault(c => c.Name == cleansingCenterName);

            // Check if these centers exists
            if (currentAdoptionCenter == null || currentCleansingCenter == null)
            {
                return;
            }

            // Transfer animals for cleansing
            var uncleansedAnimals = currentAdoptionCenter.GetUncleansedAnimals();
            currentCleansingCenter.AddAnimalsForCleansing(uncleansedAnimals, adoptionCenterName);
        }

        public void SendForCastration(string adoptionCenterName, string castrationCenterName)
        {
            // Sends all animals from the given Adoption center to the given Castration center.
            var currentAdoptionCenter = this.adoptionCenters.FirstOrDefault(ac => ac.Name == adoptionCenterName);
            var currentCastrationCenter = this.castrationCenters.FirstOrDefault(cc => cc.Name == castrationCenterName);

            if (currentAdoptionCenter == null || currentCastrationCenter == null)
            {
                return;
            }

            currentCastrationCenter.AcceptAnimals(adoptionCenterName, currentAdoptionCenter.GetAllAnimals());
        }

        public void RegisterCat(string name, int age, int intelligenceCoefficient, string adoptionCenterName)
        {
            var currentAdoptionCenter = this.adoptionCenters.FirstOrDefault(c => c.Name == adoptionCenterName);

            if (currentAdoptionCenter == null)
            {
                return;
            }

            currentAdoptionCenter.AddAnimal(new Cat(name, age, intelligenceCoefficient));
        }

        public void RegisterDog(string name, int age, int learnedCommands, string adoptionCenterName)
        {
            var currentAdoptionCenter = this.adoptionCenters.FirstOrDefault(c => c.Name == adoptionCenterName);

            if (currentAdoptionCenter == null)
            {
                return;
            }

            currentAdoptionCenter.AddAnimal(new Dog(name, age, learnedCommands));
        }

        public void RegisterCastrationCenter(string name)
        {
            this.castrationCenters.Add(new CastrationCenter(name));
        }

        public void RegisterAdoptionCenter(string name)
        {
            this.adoptionCenters.Add(new AdoptionCenter(name));
        }

        public void RegisterCleansingCenter(string name)
        {
            this.cleansingCenters.Add(new CleansingCenter(name));
        }

        public string PrintCastrationCentersStat()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Paw Inc. Regular Castration Statistics")
                .AppendLine($"Castration Centers: {this.castrationCenters.Count}");

            var totalCastratedAnimals = new List<string>();
            foreach (var center in this.castrationCenters)
            {
                totalCastratedAnimals.AddRange(center.CastratedAnimals.Select(a => a.Name));
            }

            sb.AppendLine(totalCastratedAnimals.Count == 0
                ? "Castrated Animals: None"
                : $"Castrated Animals: {string.Join(", ", totalCastratedAnimals.OrderBy(name => name))}");

            return sb.ToString().Trim();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Paw Incorporative Regular Statistics")
                .AppendLine($"Adoption Centers: {this.adoptionCenters.Count}")
                .AppendLine($"Cleansing Centers: {this.cleansingCenters.Count}");

            List<string> totalAdoptedAnimals = new List<string>();
            foreach (var adoptionCenter in this.adoptionCenters)
            {
                totalAdoptedAnimals.AddRange(adoptionCenter.AdoptedAnimals.Select(a => a.Name));
            }

            sb.AppendLine(totalAdoptedAnimals.Count == 0
                ? $"Adopted Animals: None"
                : $"Adopted Animals: {string.Join(", ", totalAdoptedAnimals.OrderBy(name => name))}");

            List<string> totalCleansedAnimals = new List<string>();
            foreach (var cleansingCenter in this.cleansingCenters)
            {
                totalCleansedAnimals.AddRange(cleansingCenter.CleansedStat.Select(a => a.Name));
            }

            sb.AppendLine(totalCleansedAnimals.Count == 0
                ? $"Cleansed Animals: None"
                : $"Cleansed Animals: {string.Join(", ", totalCleansedAnimals.OrderBy(name => name))}");

            // Show the amount of all CLEANSED animals, waiting to be adopted in the Adoption centers
            sb.AppendLine($"Animals Awaiting Adoption: {this.adoptionCenters.Select(ac => ac.WaitingAdoptionCount).Sum()}");

            // Show the amount of all UNCLEANSED animals, waiting to be cleansed in the Cleansing centers
            sb.AppendLine($"Animals Awaiting Cleansing: {this.cleansingCenters.Select(cc => cc.AwaitingCleansing).Sum()}");

            return sb.ToString();
        }
    }
}
