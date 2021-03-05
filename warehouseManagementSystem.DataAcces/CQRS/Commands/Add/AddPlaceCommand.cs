using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public class AddPlaceCommand : CommandBase<Place, Place>
    {
        public override async Task<Place> Execute(WarehouseStorageContext context)
        {
            await context.Places.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
