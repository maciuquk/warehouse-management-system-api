using System.Collections.Generic;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string PhotoUrl { get; set; }
        public List<DataAcces.Entities.PZ> PZs { get; set; }
        public List<DataAcces.Entities.WZ> WZs { get; set; }
        public List<DataAcces.Entities.MM> MMs { get; set; }
        public List<DataAcces.Entities.Place> Places { get; set; }
        public List<DataAcces.Entities.Warehouse> Warehouses { get; set; }
    }
}

