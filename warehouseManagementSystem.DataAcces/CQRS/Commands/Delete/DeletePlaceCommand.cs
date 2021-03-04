using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Delete
{
    public class DeletePlaceCommand : CommandBase<Place, Place>
    {
        public override async Task<Place> Execute(WarehouseStorageContext context)
        {
            context.Places.Remove(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}

