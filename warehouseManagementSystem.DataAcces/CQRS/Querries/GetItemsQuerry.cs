using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetItemsQuerry : QueryBase<List<Item>>
    {
        public string Name { get; set; }

        public override Task<List<Item>> Execute(WarehouseStorageContext context)
        {
            if (this.Name != null)
            {
                return context.Items.Where(x => x.Name == this.Name).ToListAsync();

            }
            else
            {
                return context.Items.ToListAsync();
            }
        }


    }
}

