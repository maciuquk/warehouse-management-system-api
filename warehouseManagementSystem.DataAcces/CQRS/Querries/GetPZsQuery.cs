using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetPZsQuery : QueryBase<List<PZ>>
    {
        public override Task<List<PZ>> Execute(WarehouseStorageContext context)
        {
            return context.PZs.ToListAsync();
        }
    }
}
