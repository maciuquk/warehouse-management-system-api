using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteWZCommand : CommandBase<WZ, WZ>
    {
        public override async Task<WZ> Execute(WarehouseStorageContext context)
        {
            context.WZs.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

