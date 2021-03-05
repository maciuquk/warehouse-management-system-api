using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.DataAcces
{
    public class QueryExecutor : IQuerryExecutor
    {
        private readonly WarehouseStorageContext context;

        public QueryExecutor(WarehouseStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(this.context);
        }
    }
}
