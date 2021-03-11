using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteGoodsIssuedCommand : CommandBase<GoodsIssued, GoodsIssued>
    {
        public override async Task<GoodsIssued> Execute(WarehouseStorageContext context)
        {
            context.GoodsIssueds.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

