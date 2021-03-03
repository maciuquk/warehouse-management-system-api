using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.DataAcces.CQRS.Commands;

namespace warehouseManagementSystem.DataAcces.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly WarehouseStorageContext context;

        public CommandExecutor(WarehouseStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
