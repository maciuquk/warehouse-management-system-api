using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands.Put;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Put
{
    public class PutInterBranchTransferHandler : IRequestHandler<PutInterBranchTransferRequest, PutInterBranchTransferResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutInterBranchTransferHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutInterBranchTransferResponse> Handle(PutInterBranchTransferRequest request, CancellationToken cancellationToken)
        {
            var interBranchTransfer = this.mapper.Map<InterBranchTransfer>(request);
            var command = new PutInterBranchTransferCommand() { Parameter = interBranchTransfer };
            var interBranchTransferFromDb = await this.commandExecutor.Execute(command);

            return new PutInterBranchTransferResponse()
            {
                Data = this.mapper.Map<Domain.Models.InterBranchTransfer>(interBranchTransferFromDb)
            };
        }
    }
}
