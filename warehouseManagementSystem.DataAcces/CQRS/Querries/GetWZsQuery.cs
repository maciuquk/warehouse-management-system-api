using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetWZsQuery : QueryBase<List<WZ>>
    {
        public string Number { get; set; }

        public override Task<List<WZ>> Execute(WarehouseStorageContext context)
        {
            if (this.Number.Any())
            {
                return context.WZs.Where(x => x.Number == this.Number).ToListAsync();

            }
            else
            {
                return context.WZs.ToListAsync();

            }
        }
    }
}
