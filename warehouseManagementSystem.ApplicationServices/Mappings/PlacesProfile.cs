using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
   public class PlacesProfile : Profile
    {
        public PlacesProfile()
        {
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
