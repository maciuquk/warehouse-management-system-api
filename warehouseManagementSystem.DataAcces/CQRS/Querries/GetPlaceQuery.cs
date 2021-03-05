using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetPlaceQuery : QueryBase<Place>
    {
        public int Id { get; set; }

        public override async Task<Place> Execute(WarehouseStorageContext context)
        {
            var place = await context.Places.FirstOrDefaultAsync(x => x.Id == this.Id);
            return place;
        }
    }
}
