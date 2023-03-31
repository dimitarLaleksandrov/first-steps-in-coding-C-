using Footballers.Data.Models;

namespace Footballers.DataProcessor
{
    using AutoMapper.QueryableExtensions;
    using AutoMapper;
    using Data;
    using System.Text;
    using System.Xml.Serialization;
    using Footballers.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Globalization;
    using Microsoft.EntityFrameworkCore;

    public class Serializer
    {
        public static string ExportCoachesWithTheirFootballers(FootballersContext context)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<FootballersProfile>();
            });
            var mapper = new Mapper(config);

            StringBuilder sb = new StringBuilder();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCoachDto[]), new XmlRootAttribute("Coaches"));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            using StringWriter sw = new StringWriter(sb);

            var coaches = context
                .Coaches
                //.Include(c => c.Footballers)
                .Where(c => c.Footballers.Any())
                .OrderByDescending(c => c.Footballers.Count)
                .ThenBy(c => c.Name)
                .ToArray();
            var coachesDtos = coaches.Select(c => mapper.Map<ExportCoachDto>(c)).ToArray();
            xmlSerializer.Serialize(sw, coachesDtos, namespaces);
            return sb.ToString().TrimEnd();
        }

        public static string ExportTeamsWithMostFootballers(FootballersContext context, DateTime date)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<FootballersProfile>();
            });
            var mapper = new Mapper(config);

            var teams = context.Teams
                .Where(t => t.TeamsFootballers.Any(f => f.Footballer.ContractStartDate >= date))
                .ToArray()
                .Select(t =>
                {
                    t.TeamsFootballers = t.TeamsFootballers.Where(f => f.Footballer.ContractStartDate >= date).ToList();
                    var dto = mapper.Map<ExportTeamDto>(t);
                    return dto;

                 })
                .OrderByDescending(x => x.Footballers.Count())
                .ThenBy(t => t.Name)
                .Take(5);
                            
            return JsonConvert.SerializeObject(teams, Formatting.Indented);
        }
        //var text = "Select the top 5 teams that have at least one footballer " +
        //    "that their contract start date is higher or equal to the given date. " +
        //    "Select them with their footballers who meet the same criteria " +
        //    "(their contract start date is after or equals the given date). " +
        //    "For each team, export their name and their footballers. " +
        //    "For each footballer, export their name and contract start date " +
        //    "(must be in format \"d\"), contract end date (must be in format \"d\"), " +
        //    "position and best skill type. Order the footballers by contract end date (descending), " +
        //    "then by name (ascending). Order the teams by all footballers (meeting above condition) count (descending), " +
        //    "then by name (ascending).";
    }
}

