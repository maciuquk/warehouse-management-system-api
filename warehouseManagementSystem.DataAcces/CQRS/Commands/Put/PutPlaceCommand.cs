using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands.Put
{
    public class PutPlaceCommand : CommandBase<Place, Place>
    {
        public override async Task<Place> Execute(WarehouseStorageContext context)
        {
            context.Places.Update(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
