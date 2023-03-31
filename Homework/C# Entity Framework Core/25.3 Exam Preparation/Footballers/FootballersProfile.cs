namespace Footballers
{
    using AutoMapper;
    using Footballers.Data.Models;
    using Footballers.DataProcessor.ImportDto;
    using System.Globalization;

    // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE OR RENAME THIS CLASS
    public class FootballersProfile : Profile
    {
        public FootballersProfile()
        {
            this.CreateMap<ImportCoachDto, Coach>()
                .ForMember(dto => dto.Name, m => m.MapFrom(c => c.Name))
                .ForMember(dto => dto.Nationality, m => m.MapFrom(c => c.Nationality))
                .ForMember(dto => dto.Footballers, m => m.Ignore());
            //.ForMember(dto => dto.Footballers, m => m.MapFrom(c => c.Footballers));
            this.CreateMap<ImportFootballerDto, Footballer>()
                .ForMember(dto => dto.Name, m => m.MapFrom(f => f.Name))
                .ForMember(dto => dto.ContractStartDate, m => m.MapFrom(c => (DateTime.Parse(c.ContractStartDate))))
                .ForMember(dto => dto.ContractEndDate, m => m.MapFrom(c => (DateTime.Parse(c.ContractEndDate))))
                .ForMember(dto => dto.BestSkillType, m => m.MapFrom(f => f.BestSkillType))
                .ForMember(dto => dto.PositionType, m => m.MapFrom(f => f.PositionType));
            //DateTime.TryParseExact(footballerDto.ContractStartDate,
            //            "dd/MM/yyyy", CultureInfo.InvariantCulture,
            //            DateTimeStyles.None



        }
    }
}
