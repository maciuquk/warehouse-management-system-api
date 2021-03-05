using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.CQRS.Commands.Put;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Put
{
    public class PutMMHandler : IRequestHandler<PutMMRequest, PutMMResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutMMHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutMMResponse> Handle(PutMMRequest request, CancellationToken cancellationToken)
        {
            var mm = this.mapper.Map<MM>(request);
            var command = new PutMMCommand() { Parameter = mm };
            var mmFromDb = await this.commandExecutor.Execute(command);

            return new PutMMResponse()
            {
                Data = this.mapper.Map<Domain.Models.MM>(mmFromDb)
            };
        }
    }
}
