using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetGoodsIssuedsQuery : QueryBase<List<GoodsIssued>>
    {
        public string Number { get; set; }

        public override Task<List<GoodsIssued>> Execute(WarehouseStorageContext context)
        {
            if (this.Number != null)
            {
                return context.GoodsIssueds.Where(x => x.Number == this.Number).ToListAsync();
            }
            else
            {
                return context.GoodsIssueds.ToListAsync();
            }
        }
    }
}
