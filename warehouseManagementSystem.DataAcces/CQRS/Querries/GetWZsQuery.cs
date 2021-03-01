﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public class GetWZsQuery : QueryBase<List<WZ>>
    {
        public override Task<List<WZ>> Execute(WarehouseStorageContext context)
        {
            return context.WZs.ToListAsync();

        }
    }
}