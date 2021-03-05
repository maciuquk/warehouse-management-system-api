using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetMMQuery : QueryBase<MM>
    {
        public int Id { get; set; }

        public override async Task<MM> Execute(WarehouseStorageContext context)
        {
            var mm = await context.MMs.FirstOrDefaultAsync(x => x.Id == this.Id);
            return mm;
        }
    }
}
