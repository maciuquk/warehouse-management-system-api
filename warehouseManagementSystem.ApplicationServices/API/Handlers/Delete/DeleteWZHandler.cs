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
    public class DeleteWZHandler : IRequestHandler<DeleteWZRequest, DeleteWZResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteWZHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteWZResponse> Handle(DeleteWZRequest request, CancellationToken cancellationToken)
        {
            var wz = this.mapper.Map<WZ>(request);
            var command = new DeleteWZCommand() { Parameter = wz };
            var wzFromDb = await this.commandExecutor.Execute(command);

            return new DeleteWZResponse()
            {
                Data = this.mapper.Map<Domain.Models.WZ>(wzFromDb)
            };
        }
    }
}

