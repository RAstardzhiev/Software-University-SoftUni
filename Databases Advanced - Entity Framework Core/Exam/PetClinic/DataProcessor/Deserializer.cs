namespace PetClinic.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using PetClinic.Data;
    using PetClinic.DataProcessor.Dto.Import;
    using PetClinic.DataProcessor.Dto.Import.Procedure;
    using PetClinic.Models;

    public class Deserializer
    {
        public static string ImportAnimalAids(PetClinicContext context, string jsonString)
        {
            var deserializedAids = JsonConvert.DeserializeObject<AnimalAidDto[]>(jsonString);

            var sb = new StringBuilder();

            var validAids = new HashSet<AnimalAid>();
            foreach (var dto in deserializedAids)
            {
                if (!IsValid(dto) ||
                    validAids.Any(va => va.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var aid = new AnimalAid
                {
                    Name = dto.Name,
                    Price = dto.Price
                };

                validAids.Add(aid);

                sb.AppendLine($"Record {aid.Name} successfully imported.");
            }

            context.AnimalAids.AddRange(validAids);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportAnimals(PetClinicContext context, string jsonString)
        {
            var deserializedAnimals = JsonConvert.DeserializeObject<AnimalDto[]>(jsonString);

            var sb = new StringBuilder();

            var validAnimals = new List<Animal>();
            var passports = new HashSet<Passport>();
            foreach (var dto in deserializedAnimals)
            {
                DateTime regDate;
                var isRegDateValid = DateTime.TryParse(dto.Passport.RegistrationDate, out regDate);

                if (!IsValid(dto) || !IsValid(dto.Passport) ||
                    passports.Any(p => p.SerialNumber.Equals(dto.Passport.SerialNumber, StringComparison.OrdinalIgnoreCase)))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var validPasport = new Passport
                {
                    SerialNumber = dto.Passport.SerialNumber,
                    OwnerName = dto.Passport.OwnerName,
                    OwnerPhoneNumber = dto.Passport.OwnerPhoneNumber,
                    RegistrationDate = regDate
                };

                passports.Add(validPasport);

                var animal = new Animal
                {
                    Name = dto.Name,
                    Type = dto.Type,
                    Age = dto.Age,
                    PassportSerialNumber = dto.Passport.SerialNumber, 
                    Passport = validPasport
                };

                validAnimals.Add(animal);

                sb.AppendLine($"Record {animal.Name} Passport №: {animal.PassportSerialNumber} successfully imported.");
            }

            context.Animals.AddRange(validAnimals);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportVets(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(VetDto[]), new XmlRootAttribute("Vets"));
            var deserializedVets = (VetDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var sb = new StringBuilder();

            var validVets = new HashSet<Vet>();
            foreach (var dto in deserializedVets)
            {
                if (!IsValid(dto) ||
                    validVets.Any(v => v.PhoneNumber.Equals(dto.PhoneNumber, StringComparison.OrdinalIgnoreCase)))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var vet = new Vet
                {
                    Name = dto.Name,
                    Profession = dto.Profession,
                    Age = dto.Age,
                    PhoneNumber = dto.PhoneNumber
                };

                validVets.Add(vet);

                sb.AppendLine($"Record {vet.Name} successfully imported.");
            }

            context.Vets.AddRange(validVets);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        public static string ImportProcedures(PetClinicContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ProcedureDto[]), new XmlRootAttribute("Procedures"));
            var deserializedProcedures = (ProcedureDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var sb = new StringBuilder();

            var validProcedures = new List<Procedure>();
            foreach (var dto in deserializedProcedures)
            {
                DateTime procedureDate;
                var isProcDateValid = DateTime.TryParseExact(dto.ProcedureDate,
                    "dd-MM-yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out procedureDate);

                if (!IsValid(dto) ||
                    dto.AnimalAids.Length != dto.AnimalAids.Select(a => a.Name).Distinct().Count())
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var vet = context.Vets
                    .FirstOrDefault(v => v.Name.Equals(dto.VetName, StringComparison.OrdinalIgnoreCase));
                if (vet == null)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var animal = context.Animals
                    .FirstOrDefault(a => a.PassportSerialNumber.Equals(dto.AnimalSerialNumber, StringComparison.OrdinalIgnoreCase));
                if (animal == null)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var aids = context.AnimalAids
                    .Where(a => dto.AnimalAids.Any(dtoAid => dtoAid.Name.Equals(a.Name, StringComparison.OrdinalIgnoreCase)))
                    .ToArray();
                if (aids.Length != dto.AnimalAids.Length)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var mappings = new List<ProcedureAnimalAid>();
                foreach (var dbAid in aids)
                {
                    mappings.Add(new ProcedureAnimalAid
                    {
                        AnimalAidId = dbAid.Id
                    });
                }

                var proc = new Procedure
                {
                    VetId = vet.Id,
                    AnimalId = animal.Id,
                    DateTime = procedureDate,
                    ProcedureAnimalAids = mappings
                };

                validProcedures.Add(proc);

                sb.AppendLine("Record successfully imported.");
            }

            context.Procedures.AddRange(validProcedures);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}
