using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class PZsProfile : Profile
    {
        public PZsProfile()
        {
            this.CreateMap<AddPZRequest, DataAcces.Entities.PZ>()
                  .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.Date));
            //.ForMember(x => x.Items, y => y.MapFrom(z => z.Items));

            this.CreateMap<DeletePZRequest, DataAcces.Entities.PZ>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<DataAcces.Entities.PZ, PZ>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Number, y => y.MapFrom(z => z.Number))
                .ForMember(x => x.Date, y => y.MapFrom(z => z.Date))
                .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}
