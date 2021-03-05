using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddWarehouseCommand : CommandBase<Warehouse, Warehouse>
    {
        public override async Task<Warehouse> Execute(WarehouseStorageContext context)
        {
            await context.Warehouses.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
