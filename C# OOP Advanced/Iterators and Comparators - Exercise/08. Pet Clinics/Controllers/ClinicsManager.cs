namespace _08.Pet_Clinics.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class ClinicsManager
    {
        private IList<Pet> pets;
        private IList<Clinic> clinics;

        public ClinicsManager()
        {
            this.pets = new List<Pet>();
            this.clinics = new List<Clinic>();
        }

        internal void CreatePet(string name, int age, string kind) => this.pets.Add(new Pet(name, age, kind));

        internal void CreateClinic(string name, int rooms) => this.clinics.Add(new Clinic(name, rooms));

        internal bool HasEmptyRooms(string clinicName) => this.GetConcreteClinic(clinicName).HasEmptyRooms();

        internal string PrintClinic(string clinicName) => this.GetConcreteClinic(clinicName).GetAllRomsState();

        internal string PrintRoom(string clinicName, int roomNumber) => this.GetConcreteClinic(clinicName).GetRoomState(roomNumber);
        
        internal bool ReleaseAnumalFromClinic(string clinicName) => this.GetConcreteClinic(clinicName).ReleaseAnimal();

        internal bool AddPetToAClinic(string petName, string clinicName)
        {
            var currentPet = this.GetConcretePet(petName);
            var currentClinic = this.GetConcreteClinic(clinicName);
            return currentClinic.AddPet(currentPet);
        }

        private Pet GetConcretePet(string petName)
        {
            var currentPet = this.pets.FirstOrDefault(p => p.Name == petName);
            if (currentPet == null)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return currentPet;
        }

        private Clinic GetConcreteClinic(string clinicName)
        {
            var currentClinic = this.clinics.FirstOrDefault(c => c.Name == clinicName);
            if (currentClinic == null)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return currentClinic;
        }
    }
}
