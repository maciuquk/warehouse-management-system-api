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
    public class PutPZHandler : IRequestHandler<PutPZRequest, PutPZResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutPZHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutPZResponse> Handle(PutPZRequest request, CancellationToken cancellationToken)
        {
            var pz = this.mapper.Map<PZ>(request);
            var command = new PutPZCommand() { Parameter = pz };
            var pzFromDb = await this.commandExecutor.Execute(command);

            return new PutPZResponse()
            {
                Data = this.mapper.Map<Domain.Models.PZ>(pzFromDb)
            };
        }
    }
}
