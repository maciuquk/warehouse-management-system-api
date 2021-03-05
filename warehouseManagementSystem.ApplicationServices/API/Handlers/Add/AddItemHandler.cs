using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class AddItemHandler : IRequestHandler<AddItemRequest, AddItemResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddItemHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddItemResponse> Handle(AddItemRequest request, CancellationToken cancellationToken)
        {
            var item = this.mapper.Map<Item>(request);
            var command = new AddItemCommand() { Parameter = item };
            var itemFromDb = await this.commandExecutor.Execute(command);

            return new AddItemResponse()
            {
                Data = this.mapper.Map<Domain.Models.Item>(itemFromDb)
            };
        }
    }
}
