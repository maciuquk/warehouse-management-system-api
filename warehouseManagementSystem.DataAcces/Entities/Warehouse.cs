using System.Collections.Generic;

namespace warehouseManagementSystem.DataAcces.Entities
{
    public class Warehouse : EntityBase
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
