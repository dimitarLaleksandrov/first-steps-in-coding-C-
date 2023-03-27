namespace Footballers.DataProcessor
{
    using Castle.Core.Internal;
    using Footballers.Data;
    using Footballers.Data.Models;
    using Footballers.Data.Models.Enums;
    using Footballers.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCoach
            = "Successfully imported coach - {0} with {1} footballers.";

        private const string SuccessfullyImportedTeam
            = "Successfully imported team - {0} with {1} footballers.";

        public static string ImportCoaches(FootballersContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCoachesDto[]), new XmlRootAttribute("Coaches"));
            using StringReader xmlReader = new StringReader(xmlString);
            ImportCoachesDto[] coachDtos = (ImportCoachesDto[])xmlSerializer.Deserialize(xmlReader)!;
            HashSet<Coach> coaches = new HashSet<Coach>();
            foreach (var cDto in coachDtos)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (cDto.Name.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (cDto.Nationality.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                Coach coach = new Coach() 
                { 
                    Name = cDto.Name,
                    Nationality = cDto.Nationality
                };
                foreach (var fDto in cDto.Footballers!)
                {
                    if (!IsValid(fDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (fDto.Name.IsNullOrEmpty())
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    DateTime fContractStartDate;
                    bool isFContractStartDate = DateTime.TryParseExact(fDto.ContractStartDate,
                        "dd/MM/yyyy", CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out fContractStartDate);
                    if (!isFContractStartDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    DateTime fContractEndDate;
                    bool isFContractEndDate = DateTime.TryParseExact(fDto.ContractEndDate,
                        "dd/MM/yyyy", CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out fContractEndDate);
                    if (!isFContractEndDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    if (fContractStartDate >= fContractEndDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    Footballer footballer = new Footballer()
                    {
                        Name = fDto.Name,
                        ContractStartDate = fContractStartDate,
                        ContractEndDate = fContractEndDate,
                        BestSkillType = (BestSkillType)fDto.BestSkillType,
                        PositionType = (PositionType)fDto.PositionType
                    };
                    coach.Footballers.Add(footballer);
                }
                coaches.Add(coach);
                sb.AppendLine(string.Format(SuccessfullyImportedCoach, coach.Name, coach.Footballers.Count));

            }
            context.Coaches.AddRange(coaches);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportTeams(FootballersContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportTeamsDto[] teamDtos = JsonConvert.DeserializeObject<ImportTeamsDto[]>(jsonString)!;
            List<Team> teams = new List<Team>();
            foreach (var tDto in teamDtos)
            {
                if (!IsValid(tDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (tDto.Name.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (tDto.Nationality.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                if (tDto.Trophies <= 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                Team team = new Team() 
                {
                    Name = tDto.Name,
                    Nationality = tDto.Nationality,
                    Trophies = tDto.Trophies,
                
                };
                foreach (var f in tDto.Footballers.Distinct()) 
                {
                    Footballer footballer = context.Footballers.Find(f);
                    if (footballer == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    team.TeamsFootballers.Add(new TeamFootballer() 
                    {  
                        Footballer = footballer
                    });
                }
                teams.Add(team);
                sb.AppendLine(string.Format(SuccessfullyImportedTeam, team.Name, team.TeamsFootballers.Count));
            }
            context.Teams.AddRange(teams);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
