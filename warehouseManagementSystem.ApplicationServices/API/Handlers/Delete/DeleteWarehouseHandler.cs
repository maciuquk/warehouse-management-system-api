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
    public class DeleteWarehouseHandler : IRequestHandler<DeleteWarehouseRequest, DeleteWarehouseResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteWarehouseHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteWarehouseResponse> Handle(DeleteWarehouseRequest request, CancellationToken cancellationToken)
        {
            var warehouse = this.mapper.Map<Warehouse>(request);
            var command = new DeleteWarehouseCommand() { Parameter = warehouse };
            var warehouseFromDb = await this.commandExecutor.Execute(command);

            return new DeleteWarehouseResponse()
            {
                Data = this.mapper.Map<Domain.Models.Warehouse>(warehouseFromDb)
            };
        }
    }
}

