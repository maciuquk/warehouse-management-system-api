using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands.Delete;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class DeleteInterBranchTransferHandler : IRequestHandler<DeleteInterBranchTransferRequest, DeleteInterBranchTransferResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteInterBranchTransferHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteInterBranchTransferResponse> Handle(DeleteInterBranchTransferRequest request, CancellationToken cancellationToken)
        {
            var interBranchTransfer = this.mapper.Map<InterBranchTransfer>(request);
            var command = new DeleteInterBranchTransferCommand() { Parameter = interBranchTransfer };
            var interBranchTransferFromDb = await this.commandExecutor.Execute(command);

            return new DeleteInterBranchTransferResponse()
            {
                Data = this.mapper.Map<Domain.Models.InterBranchTransfer>(interBranchTransferFromDb)
            };
        }
    }
}
