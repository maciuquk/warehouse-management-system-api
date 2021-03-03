﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add
{
   public class AddPlaceRequest : IRequest<AddPlaceResponse>
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentOccupied { get; set; }
        //public List<Item> Items { get; set; }
    }
}
