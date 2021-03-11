using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetGoodsReceivesQuery : QueryBase<List<GoodsReceive>>
    {
        public string Number { get; set; }

        public override Task<List<GoodsReceive>> Execute(WarehouseStorageContext context)
        {
            if (this.Number != null)
            {
                return context.GoodsReceiveds.Where(x => x.Number == this.Number).ToListAsync();
            }
            else
            {
                return context.GoodsReceiveds.ToListAsync();
            }
        }
    }
}
