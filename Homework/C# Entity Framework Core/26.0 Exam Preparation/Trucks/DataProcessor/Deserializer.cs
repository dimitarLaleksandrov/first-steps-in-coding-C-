namespace Trucks.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;
    using AutoMapper;
    using Castle.Core.Internal;
    using Data;
    using Newtonsoft.Json;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;

    public class Deserializer
    {
      
        private static readonly IMapper _mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<TrucksProfile>();
        }));

        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {

            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportDespatchersDto[]), new XmlRootAttribute("Despatchers"));
            using StringReader stringReader = new StringReader(xmlString);
            ImportDespatchersDto[] despatcherDtos = (ImportDespatchersDto[])xmlSerializer.Deserialize(stringReader);
            foreach (var despatcherDto in despatcherDtos)
            {
                if (!IsValid(despatcherDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (despatcherDto.Position.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                var dispatcher = new Despatcher()
                {
                    Name = despatcherDto.Name,
                    Position = despatcherDto.Position
                };
                foreach (var truckDto in despatcherDto.Trucks)
                {
                    if (!IsValid(truckDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    var truck = new Truck()
                    {
                        RegistrationNumber = truckDto.RegistrationNumber,
                        VinNumber = truckDto.VinNumber,
                        TankCapacity = truckDto.TankCapacity,
                        CargoCapacity = truckDto.CargoCapacity,
                        CategoryType = (CategoryType)truckDto.CategoryType,
                        MakeType = (MakeType)truckDto.MakeType
                    };
                    dispatcher.Trucks.Add(truck);
                }
                context.Despatchers.Add(dispatcher);
                sb.AppendLine(String.Format(SuccessfullyImportedDespatcher, dispatcher.Name, dispatcher.Trucks.Count));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
            //StringBuilder sb = new StringBuilder();
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportDespatchersDto[]), new XmlRootAttribute("Despatchers"));
            //using StringReader xmlReader = new StringReader(xmlString);
            //var xmlDeserialize = (ImportDespatchersDto[])xmlSerializer.Deserialize(xmlReader)!;
            //foreach (var dispatcherDto in xmlDeserialize)
            //{               
            //    if (!IsValid(dispatcherDto))
            //    {
            //        sb.AppendLine(ErrorMessage);
            //        continue;
            //    }
            //    if (dispatcherDto.Position.IsNullOrEmpty())
            //    {
            //        sb.AppendLine(ErrorMessage);
            //        continue;
            //    }
            //    Despatcher dispatcher = _mapper.Map<Despatcher>(dispatcherDto);
            //    //Despatcher despatcher = new Despatcher
            //    //{
            //    //    Name = dispatcherDto.Name,
            //    //    Position = dispatcherDto.Position
            //    //};
            //    var trucks = new List<Truck>();
            //    foreach (var truckDto in dispatcherDto.Trucks)
            //    {
            //        if (!IsValid(truckDto))
            //        {
            //            sb.AppendLine(ErrorMessage);
            //            continue;
            //        }
            //        var truck = _mapper.Map<Truck>(truckDto);
            //        trucks.Add(truck);
            //    }

            //    dispatcher.Trucks = trucks;
            //    context.Despatchers.Add(dispatcher);
            //    sb.AppendLine(string.Format(SuccessfullyImportedDespatcher, dispatcher.Name, dispatcher.Trucks.Count));
            //}

            //context.SaveChanges();
            //return sb.ToString().TrimEnd();
        }
        public static string ImportClient(TrucksContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportClientDto[] clientDtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);

            foreach (ImportClientDto clientDto in clientDtos)
            {
                if (!IsValid(clientDto) || clientDto.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                } 
                var client = new Client()
                {
                    Name = clientDto.Name,
                    Nationality = clientDto.Nationality,
                    Type = clientDto.Type,
                };       
                foreach (int truckId in clientDto.Trucks.Distinct())
                {
                    var truck = context.Trucks.Find(truckId);
                    if (truck == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    client.ClientsTrucks.Add(new ClientTruck()
                    {
                        Truck = truck
                    });
                }
                context.Clients.Add(client);
                sb.AppendLine(String.Format(SuccessfullyImportedClient, client.Name, client.ClientsTrucks.Count));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();

            //StringBuilder sb = new StringBuilder();
            //ImportClientDto[] clientsDtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);
            //List<Client> clients = new List<Client>();
            //foreach (var clientDto in clientsDtos)
            //{
            //    if (!IsValid(clientDto))
            //    {
            //        sb.AppendLine(ErrorMessage);
            //        continue;
            //    }
            //    if (clientDto.Type == "usual")
            //    {
            //        sb.AppendLine(ErrorMessage);
            //        continue;
            //    }
            //    Client client = _mapper.Map<Client>(clientDto);
            //    var trucks = new List<int>();
            //    foreach (var truckId in clientDto.Trucks.Distinct())
            //    {
            //        var truck = context.Trucks.Any(t => t.Id == truckId);
            //        if (truck)
            //        {
            //            sb.AppendLine(ErrorMessage);
            //            continue;
            //        }
            //        ClientTruck ct = new ClientTruck() 
            //        { 
            //            Client = client,
            //            TruckId = truckId

            //        };
            //        client.ClientsTrucks.Add(ct);         
            //    }
            //    context.Clients.Add(client);
            //    sb.AppendLine(string.Format(SuccessfullyImportedClient, client.Name, client.ClientsTrucks.Count));
            //}
            //context.SaveChanges();
            //return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}