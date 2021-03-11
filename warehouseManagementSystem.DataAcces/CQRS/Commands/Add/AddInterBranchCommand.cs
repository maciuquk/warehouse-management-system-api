using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddInterBranchCommand : CommandBase<InterBranchTransfer, InterBranchTransfer>
    {
        public override async Task<InterBranchTransfer> Execute(WarehouseStorageContext context)
        {
            await context.InterBranchTransfers.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }

}
