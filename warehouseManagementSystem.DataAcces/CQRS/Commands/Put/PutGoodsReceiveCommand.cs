using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutGoodsReceiveCommand : CommandBase<GoodsReceive, GoodsReceive>
    {
        public override async Task<GoodsReceive> Execute(WarehouseStorageContext context)
        {
            context.GoodsReceiveds.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}