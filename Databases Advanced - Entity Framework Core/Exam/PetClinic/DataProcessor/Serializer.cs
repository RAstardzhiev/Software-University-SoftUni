namespace PetClinic.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using PetClinic.Data;
    using PetClinic.DataProcessor.Dto.Export;

    public class Serializer
    {
        public static string ExportAnimalsByOwnerPhoneNumber(PetClinicContext context, string phoneNumber)
        {
            var animals = context.Animals
                .Where(a => a.Passport.OwnerPhoneNumber.Equals(phoneNumber, StringComparison.OrdinalIgnoreCase))
                .Select(a => new
                {
                    OwnerName = a.Passport.OwnerName,
                    AnimalName = a.Name,
                    Age = a.Age,
                    SerialNumber = a.Passport.SerialNumber,
                    RegisteredOn = a.Passport.RegistrationDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
                })
                .OrderBy(a => a.Age)
                .ThenBy(a => a.SerialNumber)
                .ToArray();

            var jsonString = JsonConvert.SerializeObject(animals, Newtonsoft.Json.Formatting.Indented);
            return jsonString;
        }

        public static string ExportAllProcedures(PetClinicContext context)
        {
            var procedures = context.Procedures
                .Select(p => new 
                {
                    Passport = p.Animal.Passport.SerialNumber,
                    OwnerNumber = p.Animal.Passport.OwnerPhoneNumber,
                    DateTime = p.DateTime,
                    AnimalAids = p.ProcedureAnimalAids
                        .Select(paa => paa.AnimalAid)
                        .Select(aa => new ProcedureExportAnimalAidDto
                        {
                            Name = aa.Name, 
                            Price = aa.Price
                        })
                        .ToArray(),
                    TotalPrice = p.Cost
                })
                .OrderBy(p => p.DateTime)
                .ThenBy(p => p.Passport)
                .Select(p => new ProcedureExportDto
                {
                    Passport = p.Passport, 
                    OwnerNumber = p.OwnerNumber, 
                    DateTime = p.DateTime.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture), 
                    AnimalAids = p.AnimalAids, 
                    TotalPrice = p.TotalPrice
                })
                .ToArray();
            // toto

            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(ProcedureExportDto[]), new XmlRootAttribute("Procedures"));
            serializer.Serialize(new StringWriter(sb), procedures, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString();
            return result;
        }
    }
}
