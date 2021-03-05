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
    public class PutWZHandler : IRequestHandler<PutWZRequest, PutWZResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutWZHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutWZResponse> Handle(PutWZRequest request, CancellationToken cancellationToken)
        {
            var wz = this.mapper.Map<WZ>(request);
            var command = new PutWZCommand() { Parameter = wz };
            var wzFromDb = await this.commandExecutor.Execute(command);

            return new PutWZResponse()
            {
                Data = this.mapper.Map<Domain.Models.WZ>(wzFromDb)
            };
        }
    }
}
