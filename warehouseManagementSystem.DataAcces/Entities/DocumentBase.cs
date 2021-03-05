using System;
using System.Collections.Generic;

namespace warehouseManagementSystem.DataAcces.Entities
{
    public abstract class DocumentBase : EntityBase
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public List<Item> Items { get; set; }

    }
}
