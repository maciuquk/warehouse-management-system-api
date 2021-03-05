using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.CQRS.Commands.Put;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Put
{
    public class PutPlaceHandler : IRequestHandler<PutPlaceRequest, PutPlaceResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutPlaceHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutPlaceResponse> Handle(PutPlaceRequest request, CancellationToken cancellationToken)
        {
            var place = this.mapper.Map<Place>(request);
            var command = new PutPlaceCommand() { Parameter = place };
            var placeFromDb = await this.commandExecutor.Execute(command);

            return new PutPlaceResponse()
            {
                Data = this.mapper.Map<Domain.Models.Place>(placeFromDb)
            };
        }
    }
}
