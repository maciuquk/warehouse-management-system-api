using Microsoft.EntityFrameworkCore;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces
{
    public class WarehouseStorageContext : DbContext
    {
        public WarehouseStorageContext(DbContextOptions<WarehouseStorageContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<GoodsReceive> GoodsReceiveds { get; set; }
        public DbSet<GoodsIssued> GoodsIssueds { get; set; }
        public DbSet<InterBranchTransfer> InterBranchTransfers { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

    }


    
}
