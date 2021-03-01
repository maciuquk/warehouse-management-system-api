using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetWZQuery : QueryBase<WZ>
    {
        public int Id { get; set; }

        public override async Task<WZ> Execute(WarehouseStorageContext context)
        {
            var wz = await context.WZs.FirstOrDefaultAsync(x => x.Id == this.Id);
            return wz;
        }
    }
}
