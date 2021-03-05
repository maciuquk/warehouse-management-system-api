using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.GetById
{
    public class PutItemHandler : IRequestHandler<PutItemRequest, PutItemResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
         
        public PutItemHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutItemResponse> Handle(PutItemRequest request, CancellationToken cancellationToken)
        {
            var item = this.mapper.Map<Item>(request);
            var command = new PutItemCommand() { Parameter = item };
            var itemFromDb = await this.commandExecutor.Execute(command);

            return new PutItemResponse()
            {
                Data = this.mapper.Map<Domain.Models.Item>(itemFromDb)
            };
        }
    }
}

