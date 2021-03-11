using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddGoodsIssuedCommand : CommandBase<GoodsIssued, GoodsIssued>
    {
        public override async Task<GoodsIssued> Execute(WarehouseStorageContext context)
        {
            await context.GoodsIssueds.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
