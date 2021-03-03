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
    public class AddWZHandler : IRequestHandler<AddWZRequest, AddWZResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddWZHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddWZResponse> Handle(AddWZRequest request, CancellationToken cancellationToken)
        {
            var wz = this.mapper.Map<WZ>(request);
            var command = new AddWZCommand() { Parameter = wz };
            var wzFromDb = await this.commandExecutor.Execute(command);

            return new AddWZResponse()
            {
                Data = this.mapper.Map<Domain.Models.WZ>(wzFromDb)
            };
        }
    }
}
