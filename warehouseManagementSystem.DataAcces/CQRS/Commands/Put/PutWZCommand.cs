using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutWZCommand : CommandBase<WZ, WZ>
    {
        public override async Task<WZ> Execute(WarehouseStorageContext context)
        {
            context.WZs.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

