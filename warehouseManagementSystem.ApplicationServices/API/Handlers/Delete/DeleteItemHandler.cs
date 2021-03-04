using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands.Delete;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class DeleteItemHandler : IRequestHandler<DeleteItemRequest, DeleteItemResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteItemHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteItemResponse> Handle(DeleteItemRequest request, CancellationToken cancellationToken)
        {
            var item = this.mapper.Map<Item>(request);
            var command = new DeleteItemCommand() { Parameter = item };
            var itemFromDb = await this.commandExecutor.Execute(command);

            return new DeleteItemResponse()
            {
                Data = this.mapper.Map<Domain.Models.Item>(itemFromDb)
            };
        }
    }
}
