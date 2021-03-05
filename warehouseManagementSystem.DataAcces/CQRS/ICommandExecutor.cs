using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.CQRS.Commands;

namespace warehouseManagementSystem.DataAcces.CQRS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command);
    }
}
