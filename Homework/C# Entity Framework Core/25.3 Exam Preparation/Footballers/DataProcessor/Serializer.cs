﻿namespace Footballers.DataProcessor
{
    using Data;
    using Footballers.Data.Models;
    using Footballers.DataProcessor.ExportDto;
    using Footballers.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCoachesWithTheirFootballers(FootballersContext context)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ExportCoachDto[]), new XmlRootAttribute("Coaches"));
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            using StringWriter sw = new StringWriter(sb);
            ExportCoachDto[] coachDto = context.Coaches
                                        .Where(c => c.Footballers.Any())
                                        .Select(c => new ExportCoachDto
                                        {
                                            Name = c.Name,
                                            FootballersCount = c.Footballers.Count,
                                            Footballers = c.Footballers
                                            .Select(cf => new ExportCoachFootballerDto
                                            {
                                                Name = cf.Name,
                                                PositionType = cf.PositionType.ToString()
                                            })
                                            .OrderBy(f => f.Name)
                                            .ToArray()
                                        })
                                        .OrderByDescending(c => c.FootballersCount)
                                        .ThenBy(c => c.Name)
                                        .ToArray();


            xmlSerializer.Serialize(sw, coachDto, namespaces);
            return sb.ToString().TrimEnd();
        }
        public static string ExportTeamsWithMostFootballers(FootballersContext context, DateTime date)
        {
            var team = context.Teams
                .Where(t => t.TeamsFootballers.All(tf => tf.Footballer.ContractStartDate >= date))
                .ToArray()
                .Select(t => new ExportTeamJsonDto
                {
                    Name = t.Name,
                    Footballers = t.TeamsFootballers
                                                    .Where(tf => tf.Footballer.ContractStartDate >= date)
                                                    .Select(tf => new ExportFootballerJsonDto
                                                    {
                                                        FootballerName = tf.Footballer.Name,
                                                        ContractStartDate = tf.Footballer.ContractStartDate.ToString("d", CultureInfo.InvariantCulture),
                                                        ContractEndDate = tf.Footballer.ContractEndDate.ToString("d", CultureInfo.InvariantCulture),
                                                        BestSkillType = tf.Footballer.BestSkillType.ToString(),
                                                        PositionType = tf.Footballer.PositionType.ToString()
                                                    })
                                                    .OrderByDescending(tf => tf.ContractEndDate)
                                                    .ThenBy(tf => tf.FootballerName)
                                                    .ToArray()
                                                     })
                                                    .OrderByDescending(t => t.Footballers.Count())
                                                    .ThenBy(t => t.Name)
                                                    .Take(5)
                                                    .ToArray();

            return JsonConvert.SerializeObject(team, Formatting.Indented);

        }
    }
}