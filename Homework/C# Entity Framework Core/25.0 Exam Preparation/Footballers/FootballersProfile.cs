namespace Footballers
{
    using AutoMapper;
    using Footballers.Data.Models;
    using Footballers.DataProcessor.ExportDto;
    using System.Globalization;

    // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE OR RENAME THIS CLASS
    public class FootballersProfile : Profile
    {
        public FootballersProfile()
        {
            this.CreateMap<Footballer, ExportFootbalerDto>()
                .ForMember(dto => dto.Position, m => m.MapFrom(f => f.PositionType.ToString()));
            this.CreateMap<Coach, ExportCoachDto>()
                .ForMember(dto => dto.FootballersCount, m => m.MapFrom(c => c.Footballers.Count))
                .ForMember(dto => dto.Footballers, m => m.MapFrom(c => c.Footballers.OrderBy(f => f.Name).ToArray()));
            this.CreateMap<Footballer, ExportJSONFootballerDto>()
                .ForMember(dto => dto.ContractStartDate, m => m.MapFrom(f => f.ContractStartDate.ToString("d", CultureInfo.InvariantCulture)))
                .ForMember(dto => dto.ContractEndDate, m => m.MapFrom(f => f.ContractEndDate.ToString("d", CultureInfo.InvariantCulture)))
                .ForMember(dto => dto.PositionType, m => m.MapFrom(f => f.PositionType.ToString()))
                .ForMember(dto => dto.BestSkillType, m => m.MapFrom(f => f.BestSkillType.ToString()));
            this.CreateMap<Team, ExportTeamDto>()
                .ForMember(dto => dto.Footballers, m => m.MapFrom(x => x.TeamsFootballers
                .OrderByDescending(f => f.Footballer.ContractEndDate)
                .ThenBy(f => f.Footballer.Name)
                .Select(a => a.Footballer)));

        }
    }
}
