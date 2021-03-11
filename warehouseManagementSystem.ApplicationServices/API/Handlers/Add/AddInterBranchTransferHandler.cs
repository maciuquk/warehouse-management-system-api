using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class AddInterBranchTransferHandler : IRequestHandler<AddInterBranchTransferRequest, AddInterBranchTransferResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddInterBranchTransferHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddInterBranchTransferResponse> Handle(AddInterBranchTransferRequest request, CancellationToken cancellationToken)
        {
            var interBranchTransfer = this.mapper.Map<InterBranchTransfer>(request);
            var command = new AddInterBranchCommand() { Parameter = interBranchTransfer };
            var interBranchTransferFromDb = await this.commandExecutor.Execute(command);

            return new AddInterBranchTransferResponse()
            {
                Data = this.mapper.Map<Domain.Models.InterBranchTransfer>(interBranchTransferFromDb)
            };
        }

    }
}
