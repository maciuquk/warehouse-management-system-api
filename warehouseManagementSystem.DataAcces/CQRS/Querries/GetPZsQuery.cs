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
        public string Number { get; set; }

        public override Task<List<PZ>> Execute(WarehouseStorageContext context)
        {
            if (this.Number.Any())
            {
                return context.PZs.Where(x => x.Number == this.Number).ToListAsync();
            }
            else
            {
                return context.PZs.ToListAsync();
            }
        }
    }
}
