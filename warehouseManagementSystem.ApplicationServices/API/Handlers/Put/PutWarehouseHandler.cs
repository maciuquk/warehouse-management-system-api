using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Put
{
    public class PutWarehouseHandler : IRequestHandler<PutWarehouseRequest, PutWarehouseResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutWarehouseHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutWarehouseResponse> Handle(PutWarehouseRequest request, CancellationToken cancellationToken)
        {
            var warehouse = this.mapper.Map<Warehouse>(request);
            var command = new PutWarehouseCommand() { Parameter = warehouse };
            var warehouseFromDb = await this.commandExecutor.Execute(command);

            return new PutWarehouseResponse()
            {
                Data = this.mapper.Map<Domain.Models.Warehouse>(warehouseFromDb)
            };
        }
    }
}
