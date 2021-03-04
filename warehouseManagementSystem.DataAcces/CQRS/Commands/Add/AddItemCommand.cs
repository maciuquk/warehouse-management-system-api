using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddItemCommand : CommandBase<Item, Item>
    {
        public override async Task<Item> Execute(WarehouseStorageContext context)
        {
            await context.Items.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
