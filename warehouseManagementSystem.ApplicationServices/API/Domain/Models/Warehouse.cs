using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class Warehouse
    {
        public string Name { get; set; }
        public List<DataAcces.Entities.Item> Items { get; set; }
    }
}
