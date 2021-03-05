using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Put
{
    public class PutMMCommand : CommandBase<MM, MM>
    {
        public override async Task<MM> Execute(WarehouseStorageContext context)
        {
            context.MMs.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
