using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class GoodsIssuedsProfile : Profile
    {
        public GoodsIssuedsProfile()
        {
            this.CreateMap<AddGoodsIssuedRequest, DataAcces.Entities.GoodsIssued>()
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));

            this.CreateMap<DeleteGoodsIssuedRequest, DataAcces.Entities.GoodsIssued>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<PutGoodsIssuedRequest, DataAcces.Entities.GoodsIssued>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));

            this.CreateMap<DataAcces.Entities.GoodsIssued, GoodsIssued>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
               .ForMember(x => x.Date, y => y.MapFrom(z => z.Date))
               .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}

