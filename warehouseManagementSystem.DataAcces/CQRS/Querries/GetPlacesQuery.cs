using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetPlacesQuery : QueryBase<List<Place>>
    {
        public override Task<List<Place>> Execute(WarehouseStorageContext context)
        {
            return context.Places.ToListAsync();
        }
    }
}
