namespace Trucks
{
    using AutoMapper;
    using Trucks.Data.Models;
    using Trucks.DataProcessor.ImportDto;

    public class TrucksProfile : Profile
    {
        // Configure your AutoMapper here if you wish to use it. If not, DO NOT DELETE OR RENAME THIS CLASS
        public TrucksProfile()
        {
            this.CreateMap<ImportDespatchersDto, Despatcher>();
                //.ForMember(x => x.Trucks, opt => opt.Ignore());
            this.CreateMap<ImportTruckDto, Truck>();
            this.CreateMap<ImportClientDto, Client>();
        }
    }
}
