using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.DataAcces
{
    public interface IQuerryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);

    }
}
