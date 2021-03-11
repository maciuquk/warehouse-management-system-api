using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetGoodsIssuedQuery : QueryBase<GoodsIssued>
    {
        public int Id { get; set; }

        public override async Task<GoodsIssued> Execute(WarehouseStorageContext context)
        {
            return await context.GoodsIssueds.FirstOrDefaultAsync(x => x.Id == this.Id);
        }
    }
}
