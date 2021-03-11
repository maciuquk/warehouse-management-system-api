using AutoMapper;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            this.CreateMap<AddItemRequest, DataAcces.Entities.Item>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

            this.CreateMap<DeleteItemRequest, DataAcces.Entities.Item>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));
                

            this.CreateMap<PutItemRequest, DataAcces.Entities.Item>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Quantity))
                .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.PhotoUrl));

            this.CreateMap<DataAcces.Entities.Item, Item>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Quantity))
                .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.PhotoUrl))
                .ForMember(x => x.GoodsReceives, y => y.MapFrom(z => z.GoodsReceives))
                .ForMember(x => x.GoodsIssueds, y => y.MapFrom(z => z.GoodsIssueds))
                .ForMember(x => x.InterBranchTransfers, y => y.MapFrom(z => z.InterBranchTransfers))
                .ForMember(x => x.Places, y => y.MapFrom(z => z.Places))
                .ForMember(x => x.Warehouses, y => y.MapFrom(z => z.Warehouses));
        }
    }
}
