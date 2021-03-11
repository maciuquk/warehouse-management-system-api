using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Put
{
    public class PutInterBranchTransferCommand : CommandBase<InterBranchTransfer, InterBranchTransfer>
    {
        public override async Task<InterBranchTransfer> Execute(WarehouseStorageContext context)
        {
            context.InterBranchTransfers.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
