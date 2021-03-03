using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class AddWarehouseHandler : IRequestHandler<AddWarehouseRequest, AddWarehouseResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddWarehouseHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddWarehouseResponse> Handle(AddWarehouseRequest request, CancellationToken cancellationToken)
        {
            var warehouse = this.mapper.Map<Warehouse>(request);
            var command = new AddWarehouseCommand() { Parameter = warehouse };
            var warehouseFromDb = await this.commandExecutor.Execute(command);

            return new AddWarehouseResponse()
            {
                Data = this.mapper.Map<Domain.Models.Warehouse>(warehouseFromDb)
            };
        }
    }
}
