using Microsoft.EntityFrameworkCore;
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
        public override Task<List<Warehouse>> Execute(WarehouseStorageContext context)
        {
            return context.Warehouses.ToListAsync();
        }
    }
}
