using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteMMCommand : CommandBase<MM, MM>
    {
        public override async Task<MM> Execute(WarehouseStorageContext context)
        {
            context.MMs.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
