using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class WarehousesProfile : Profile
    {
        public WarehousesProfile()
        {
            this.CreateMap<AddWarehouseRequest, DataAcces.Entities.Warehouse>()
                  .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
            
            this.CreateMap<DeleteWarehouseRequest, DataAcces.Entities.Warehouse>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
            
            this.CreateMap<PutWarehouseRequest, DataAcces.Entities.Warehouse>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                  .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

            this.CreateMap<DataAcces.Entities.Warehouse, Warehouse>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
               .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}
