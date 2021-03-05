using System.Threading.Tasks;

namespace warehouseManagementSystem.DataAcces.CQRS.Querries
{
    public abstract class QueryBase<TResult>
    {
        public abstract Task<TResult> Execute(WarehouseStorageContext context);
    }
}
