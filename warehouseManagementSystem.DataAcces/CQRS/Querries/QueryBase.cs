using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public abstract class QueryBase<TResult>
    {
        public abstract Task<TResult> Execute(WarehouseStorageContext context);
    }
}
