using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetGoodsReceiveQuery : QueryBase<GoodsReceive>
    {
        public int Id { get; set; }

        public override async Task<GoodsReceive> Execute(WarehouseStorageContext context)
        {
            return await context.GoodsReceiveds.FirstOrDefaultAsync(x => x.Id == this.Id);
            
        }
    }
}
