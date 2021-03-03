﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;

namespace warehouseManagementSystem.ApplicationServices.Mappings
{
    public class ItemsProfile : Profile
    {
        public ItemsProfile()
        {
            this.CreateMap<AddItemRequest, DataAcces.Entities.Item>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name));

            this.CreateMap<DataAcces.Entities.Item, Item>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Quantity, y => y.MapFrom(z => z.Quantity))
                .ForMember(x => x.PhotoUrl, y => y.MapFrom(z => z.PhotoUrl))
                .ForMember(x => x.PZs, y => y.MapFrom(z => z.PZs))
                .ForMember(x => x.WZs, y => y.MapFrom(z => z.WZs))
                .ForMember(x => x.MMs, y => y.MapFrom(z => z.MMs))
                .ForMember(x => x.Places, y => y.MapFrom(z => z.Places))
                .ForMember(x => x.Warehouses, y => y.MapFrom(z => z.Warehouses));
        }
    }
}
