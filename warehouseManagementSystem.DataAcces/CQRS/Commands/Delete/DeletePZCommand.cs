using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeletePZCommand : CommandBase<PZ, PZ>
    {
        public override async Task<PZ> Execute(WarehouseStorageContext context)
        {
            context.PZs.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

