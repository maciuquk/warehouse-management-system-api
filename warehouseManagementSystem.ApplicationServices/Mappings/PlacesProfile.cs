using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class PlacesProfile : Profile
    {
        public PlacesProfile()
        {
            this.CreateMap<AddPlaceRequest, DataAcces.Entities.Place>()
                .ForMember(x => x.PositionX, y => y.MapFrom(z => z.PositionX))
                .ForMember(x => x.PositionY, y => y.MapFrom(z => z.PositionY))
                .ForMember(x => x.MaxCapacity, y => y.MapFrom(z => z.MaxCapacity))
                .ForMember(x => x.CurrentOccupied, y => y.MapFrom(z => z.CurrentOccupied));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));

            this.CreateMap<DeletePlaceRequest, DataAcces.Entities.Place>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
            
            this.CreateMap<PutPlaceRequest, DataAcces.Entities.Place>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.PositionX, y => y.MapFrom(z => z.PositionX))
                .ForMember(x => x.PositionY, y => y.MapFrom(z => z.PositionY))
                .ForMember(x => x.MaxCapacity, y => y.MapFrom(z => z.MaxCapacity))
                .ForMember(x => x.CurrentOccupied, y => y.MapFrom(z => z.CurrentOccupied));

            this.CreateMap<DataAcces.Entities.Place, Place>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.PositionX, y => y.MapFrom(z => z.PositionX))
                .ForMember(x => x.PositionY, y => y.MapFrom(z => z.PositionY))
                .ForMember(x => x.MaxCapacity, y => y.MapFrom(z => z.MaxCapacity))
                .ForMember(x => x.CurrentOccupied, y => y.MapFrom(z => z.CurrentOccupied))
                .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}
