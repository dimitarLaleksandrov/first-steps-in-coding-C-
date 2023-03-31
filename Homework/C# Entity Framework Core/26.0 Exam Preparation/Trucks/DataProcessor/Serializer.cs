namespace Trucks.DataProcessor
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Text;
    using System.Xml.Serialization;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportDespatchersWithTheirTrucks(TrucksContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportDespatcherDto[]), new XmlRootAttribute("Despatchers"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            using StringWriter sw = new StringWriter(sb);

            var despatchers = context.Despatchers
                             .Where(d => d.Trucks.Any())
                             .Select(d => new ExportDespatcherDto() 
                             { 
                                Name = d.Name,
                                TrucksCount = d.Trucks.Count,
                                Trucks = d.Trucks
                                .Select(t => new ExportDespatcherTruckDto()
                                {
                                    RegistrationNumber = t.RegistrationNumber,
                                    Make = t.MakeType.ToString()
                                })
                                .OrderBy(t => t.RegistrationNumber)
                                .ToArray()
                             })
                             .OrderByDescending(d => d.TrucksCount)
                             .ThenBy(d => d.Name)
                             .ToArray();

            xmlSerializer.Serialize(sw, despatchers, namespaces);
            return sb.ToString().TrimEnd();
        }

        public static string ExportClientsWithMostTrucks(TrucksContext context, int capacity)
        {
            var clients = context.Clients
                .ToArray()
                .Where(c => c.ClientsTrucks.Any(ct => ct.Truck.TankCapacity >= capacity))
                .Select(c => new ExportClientDto
                {
                   Name =  c.Name,
                   Trucks = c.ClientsTrucks
                                .Where(ct => ct.Truck.TankCapacity >= capacity)
                                .Select(ct => new ExportClientTruck
                                {
                                    TruckRegistrationNumber = ct.Truck.RegistrationNumber,
                                    VinNumber = ct.Truck.VinNumber,
                                    TankCapacity = ct.Truck.TankCapacity,
                                    CargoCapacity = ct.Truck.CargoCapacity,
                                    CategoryType = ct.Truck.CategoryType.ToString(),
                                    MakeType = ct.Truck.MakeType.ToString()
                                })
                                .OrderBy(c => c.MakeType)
                                .ThenByDescending(c => c.CargoCapacity)
                                .ToArray()

                })
                .OrderByDescending(c => c.Trucks.Length)
                .ThenBy(c => c.Name)
                .Take(10)
                .ToArray();
            return JsonConvert.SerializeObject(clients, Formatting.Indented);
        }
    }
}
