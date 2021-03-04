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
    public class DeletePZHandler : IRequestHandler<DeletePZRequest, DeletePZResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeletePZHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeletePZResponse> Handle(DeletePZRequest request, CancellationToken cancellationToken)
        {
            var pz = this.mapper.Map<PZ>(request);
            var command = new DeletePZCommand() { Parameter = pz };
            var pzFromDb = await this.commandExecutor.Execute(command);

            return new DeletePZResponse()
            {
                Data = this.mapper.Map<Domain.Models.PZ>(pzFromDb)
            };
        }
    }
}

