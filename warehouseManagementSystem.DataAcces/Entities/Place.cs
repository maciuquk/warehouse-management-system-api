﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.DataAcces.Entities
{
   public class Place : EntityBase
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentOccupied { get; set; }
        public List<Item> Items { get; set; }

    }
}