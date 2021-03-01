using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.DataAcces
{
    public interface IQuerryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);

    }
}
