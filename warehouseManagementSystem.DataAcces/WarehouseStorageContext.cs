using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces
{
    class WarehouseStorageContext : DbContext
    {
        public WarehouseStorageContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

    }

    
}
