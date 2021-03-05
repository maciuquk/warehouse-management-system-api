using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetPZQuery : QueryBase<PZ>
    {
        public int Id { get; set; }

        public override async Task<PZ> Execute(WarehouseStorageContext context)
        {
            var pz = await context.PZs.FirstOrDefaultAsync(x => x.Id == this.Id);
            return pz;
        }
    }
}
