using System.Threading.Tasks;

namespace warehouseManagementSystem.DataAcces.CQRS.Commands
{
    public abstract class CommandBase<TParameter, TResult>
    {
        public TParameter Parameter { get; set; }
        public abstract Task<TResult> Execute(WarehouseStorageContext context);
    }
}
