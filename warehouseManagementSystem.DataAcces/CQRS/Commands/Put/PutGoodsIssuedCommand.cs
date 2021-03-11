using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutGoodsIssuedCommand : CommandBase<GoodsIssued, GoodsIssued>
    {
        public override async Task<GoodsIssued> Execute(WarehouseStorageContext context)
        {
            context.GoodsIssueds.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

