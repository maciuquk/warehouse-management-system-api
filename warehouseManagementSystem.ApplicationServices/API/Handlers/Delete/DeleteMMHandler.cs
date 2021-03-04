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
    public class DeleteMMHandler : IRequestHandler<DeleteMMRequest, DeleteMMResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteMMHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteMMResponse> Handle(DeleteMMRequest request, CancellationToken cancellationToken)
        {
            var mm = this.mapper.Map<MM>(request);
            var command = new DeleteMMCommand() { Parameter = mm };
            var mmFromDb = await this.commandExecutor.Execute(command);

            return new DeleteMMResponse()
            {
                Data = this.mapper.Map<Domain.Models.MM>(mmFromDb)
            };
        }
    }
}
