using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace warehouseManagementSystem.DataAcces.Entities
{
    public class Item : EntityBase
    {
        [Required]
        [MaxLength(250)]
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
