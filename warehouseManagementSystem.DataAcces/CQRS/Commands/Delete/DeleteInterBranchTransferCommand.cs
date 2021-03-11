using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteInterBranchTransferCommand : CommandBase<InterBranchTransfer, InterBranchTransfer>
    {
        public override async Task<InterBranchTransfer> Execute(WarehouseStorageContext context)
        {
            context.InterBranchTransfers.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
