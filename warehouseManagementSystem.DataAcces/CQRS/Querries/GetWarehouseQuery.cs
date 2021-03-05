using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetWarehouseQuery : QueryBase<Warehouse>
    {
        public int Id { get; set; }

        public override async Task<Warehouse> Execute(WarehouseStorageContext context)
        {
            var warehouse = await context.Warehouses.FirstOrDefaultAsync(x => x.Id == this.Id);
            return warehouse;
        }
    }
}
