using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddGoodsReceiveCommand : CommandBase<GoodsReceive, GoodsReceive>
    {
        public override async Task<GoodsReceive> Execute(WarehouseStorageContext context)
        {
            await context.GoodsReceiveds.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
