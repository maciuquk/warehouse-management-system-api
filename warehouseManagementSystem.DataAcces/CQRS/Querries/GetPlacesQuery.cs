using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetPlacesQuery : QueryBase<List<Place>>
    {
        public int PositionX { get; set; }

        public override Task<List<Place>> Execute(WarehouseStorageContext context)
        {
            if (this.PositionX != 0)
            {
                return context.Places.Where(x => x.PositionX == this.PositionX).ToListAsync();

            }

            return context.Places.ToListAsync();
        }
    }
}
