using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class PutItemCommand : CommandBase<Item, Item>
    {
        public override async Task<Item> Execute(WarehouseStorageContext context)
        {
            context.Items.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

