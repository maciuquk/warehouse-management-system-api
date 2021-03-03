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
    public class AddPlaceHandler : IRequestHandler<AddPlaceRequest, AddPlaceResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddPlaceHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddPlaceResponse> Handle(AddPlaceRequest request, CancellationToken cancellationToken)
        {
            var place = this.mapper.Map<Place>(request);
            var command = new AddPlaceCommand() { Parameter = place };
            var placeFromDb = await this.commandExecutor.Execute(command);

            return new AddPlaceResponse()
            {
                Data = this.mapper.Map<Domain.Models.Place>(placeFromDb)
            };
        }

    }
}
