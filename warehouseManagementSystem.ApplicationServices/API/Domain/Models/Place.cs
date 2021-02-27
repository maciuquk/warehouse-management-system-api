using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentOccupied { get; set; }
        public List<DataAcces.Entities.Item> Items { get; set; }
    }
}
