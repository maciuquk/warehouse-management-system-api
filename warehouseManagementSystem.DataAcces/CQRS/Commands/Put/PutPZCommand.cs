using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutPZCommand : CommandBase<PZ, PZ>
    {
        public override async Task<PZ> Execute(WarehouseStorageContext context)
        {
            context.PZs.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}