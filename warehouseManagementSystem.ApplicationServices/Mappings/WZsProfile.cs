using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class WZsProfile : Profile
    {
        public WZsProfile()
        {
            this.CreateMap<AddWZRequest, DataAcces.Entities.WZ>()
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));

            this.CreateMap<DeleteWZRequest, DataAcces.Entities.WZ>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<PutWZRequest, DataAcces.Entities.WZ>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));

            this.CreateMap<DataAcces.Entities.WZ, WZ>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date))
               .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}

