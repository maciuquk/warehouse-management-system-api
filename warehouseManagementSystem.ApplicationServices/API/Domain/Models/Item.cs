using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
   public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string PhotoUrl { get; set; }
        public List<PZ> PZs { get; set; }
        public List<WZ> WZs { get; set; }
        public List<MM> MMs { get; set; }
        public List<Place> Places { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
