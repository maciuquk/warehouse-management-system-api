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
    public class AddMMHandler : IRequestHandler<AddMMRequest, AddMMResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddMMHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddMMResponse> Handle(AddMMRequest request, CancellationToken cancellationToken)
        {
            var mm = this.mapper.Map<MM>(request);
            var command = new AddMMCommand() { Parameter = mm };
            var mmFromDb = await this.commandExecutor.Execute(command);

            return new AddMMResponse()
            {
                Data = this.mapper.Map<Domain.Models.MM>(mmFromDb)
            };
        }

    }
}
