using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetInterBranchTransfersQuery : QueryBase<List<InterBranchTransfer>>
    {
        public string Number { get; set; }

        public override Task<List<InterBranchTransfer>> Execute(WarehouseStorageContext context)
        {
            if (this.Number != null)
            {
                return context.InterBranchTransfers.Where(x => x.Number == this.Number).ToListAsync();

            }
            else
            {
                return context.InterBranchTransfers.ToListAsync();
            }
        }
    }
}
