using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddMMCommand : CommandBase<MM, MM>
    {
        public override async Task<MM> Execute(WarehouseStorageContext context)
        {
            await context.MMs.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }

}
