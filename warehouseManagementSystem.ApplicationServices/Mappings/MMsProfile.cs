using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class MMsProfile : Profile
    {
        public MMsProfile()
        {
            this.CreateMap<AddMMRequest, DataAcces.Entities.MM>()
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));

            this.CreateMap<DeleteMMRequest, DataAcces.Entities.MM>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
            
            this.CreateMap<PutMMRequest, DataAcces.Entities.MM>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));

            this.CreateMap<DataAcces.Entities.MM, MM>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.Date))
                .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}
