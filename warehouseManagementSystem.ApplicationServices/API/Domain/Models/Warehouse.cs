using System.Collections.Generic;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DataAcces.Entities.Item> Items { get; set; }
    }
}
