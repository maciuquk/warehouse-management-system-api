using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteWarehouseCommand : CommandBase<Warehouse, Warehouse>
    {
        public override async Task<Warehouse> Execute(WarehouseStorageContext context)
        {
            context.Warehouses.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

