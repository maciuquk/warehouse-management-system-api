using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Models
{
    public class MM 
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public List<DataAcces.Entities.Item> Items { get; set; }
    }
}
