using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutWarehouseCommand : CommandBase<Warehouse, Warehouse>
    {
        public override async Task<Warehouse> Execute(WarehouseStorageContext context)
        {
            context.Warehouses.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

