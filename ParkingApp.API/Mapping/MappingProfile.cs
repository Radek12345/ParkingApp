using AutoMapper;
using ParkingApp.API.Controllers.Resources;
using ParkingApp.API.Core.Domain;

namespace ParkingApp.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ParkingArea, ParkingAreaResource>();
            CreateMap<ParkingAreaResource, ParkingArea>()
                .ForMember(p => p.Id, exp => exp.Ignore());
        }
    }
}