﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class WarehousesProfile : Profile
    {
        public WarehousesProfile()
        {
            this.CreateMap<DataAcces.Entities.Warehouse, Warehouse>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
               .ForMember(x => x.Items, y => y.MapFrom(z => z.Items));
        }
    }
}