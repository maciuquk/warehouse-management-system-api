﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add
{
    public class AddWarehouseRequest : IRequest<AddWarehouseResponse>
    {
        public string Name { get; set; }
        //public List<Item> Items { get; set; }
    }
}