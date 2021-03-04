﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetWarehousesQuery : QueryBase<List<Warehouse>>
    {
        public string Name { get; set; }

        public override Task<List<Warehouse>> Execute(WarehouseStorageContext context)
        {
            if (this.Name.Any())
            {
                return context.Warehouses.Where(x => x.Name == this.Name).ToListAsync();
            }
            else 
            {
                return context.Warehouses.ToListAsync(); 
            }
            
        }
    }
}
