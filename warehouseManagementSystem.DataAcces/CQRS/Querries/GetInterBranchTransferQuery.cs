using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetInterBranchTransferQuery : QueryBase<InterBranchTransfer>
    {
        public int Id { get; set; }

        public override async Task<InterBranchTransfer> Execute(WarehouseStorageContext context)
        {
            return await context.InterBranchTransfers.FirstOrDefaultAsync(x => x.Id == this.Id);
        }
    }
}
