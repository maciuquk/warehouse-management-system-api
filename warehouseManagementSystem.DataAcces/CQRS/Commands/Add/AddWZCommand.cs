using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddWZCommand : CommandBase<WZ, WZ>
    {
        public override async Task<WZ> Execute(WarehouseStorageContext context)
        {
            await context.WZs.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
