using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetMMsQuery : QueryBase<List<MM>>
    {
        public string Number { get; set; }

        public override Task<List<MM>> Execute(WarehouseStorageContext context)
        {
            if (this.Number.Any())
            {
                return context.MMs.Where(x => x.Number == this.Number).ToListAsync();

            }
            else
            {
                return context.MMs.ToListAsync();
            }
        }
    }
}
