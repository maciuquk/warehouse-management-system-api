using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeleteItemCommand : CommandBase<Item, Item>
    {
        public override async Task<Item> Execute(WarehouseStorageContext context)
        {
            context.Items.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
