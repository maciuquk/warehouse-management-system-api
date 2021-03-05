﻿using System;
using System.Collections.Generic;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class WZ
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public List<DataAcces.Entities.Item> Items { get; set; }
    }
}
