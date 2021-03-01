using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetItemQuerry : QueryBase<Item>
    {
        public int Id { get; set; }

        public override async Task<Item> Execute(WarehouseStorageContext context)
        {
            var item = await context.Items.FirstOrDefaultAsync(x => x.Id == this.Id);
            return item;
        }


    }
}
