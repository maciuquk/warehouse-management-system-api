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
    public class AddPZHandler : IRequestHandler<AddPZRequest, AddPZResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddPZHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddPZResponse> Handle(AddPZRequest request, CancellationToken cancellationToken)
        {
            var pz = this.mapper.Map<PZ>(request);
            var command = new AddPZCommand() { Parameter = pz };
            var pzFromDb = await this.commandExecutor.Execute(command);

            return new AddPZResponse()
            {
                Data = this.mapper.Map<Domain.Models.PZ>(pzFromDb)
            };
        }

    }
}
