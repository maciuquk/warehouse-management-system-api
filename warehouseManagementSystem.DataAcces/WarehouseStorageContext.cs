using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces
{
    public class WarehouseStorageContext : DbContext
    {
        public WarehouseStorageContext(DbContextOptions<WarehouseStorageContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<PZ> PZs { get; set; }
        public DbSet<WZ> WZs { get; set; }
        public DbSet<MM> MMs { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

    }


    
}
