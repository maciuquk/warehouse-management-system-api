using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteGoodsReceiveCommand : CommandBase<GoodsReceive, GoodsReceive>
    {
        public override async Task<GoodsReceive> Execute(WarehouseStorageContext context)
        {
            context.GoodsReceiveds.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

