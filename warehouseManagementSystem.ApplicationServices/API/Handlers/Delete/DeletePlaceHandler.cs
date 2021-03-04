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
    public class DeletePlaceHandler : IRequestHandler<DeletePlaceRequest, DeletePlaceResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeletePlaceHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeletePlaceResponse> Handle(DeletePlaceRequest request, CancellationToken cancellationToken)
        {
            var place = this.mapper.Map<Place>(request);
            var command = new DeletePlaceCommand() { Parameter = place };
            var placeFromDb = await this.commandExecutor.Execute(command);

            return new DeletePlaceResponse()
            {
                Data = this.mapper.Map<Domain.Models.Place>(placeFromDb)
            };
        }
    }
}
