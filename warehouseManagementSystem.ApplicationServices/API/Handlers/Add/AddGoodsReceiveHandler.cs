using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.DataAcces.CQRS;
using warehouseManagementSystem.DataAcces.CQRS.Commands;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.Add
{
    public class AddGoodsReceiveHandler : IRequestHandler<AddGoodsReceiveRequest, AddGoodsReceiveResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddGoodsReceiveHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddGoodsReceiveResponse> Handle(AddGoodsReceiveRequest request, CancellationToken cancellationToken)
        {
            var goodsReceive = this.mapper.Map<GoodsReceive>(request);
            var command = new AddGoodsReceiveCommand() { Parameter = goodsReceive };
            var goodsReceiveFromDb = await this.commandExecutor.Execute(command);

            return new AddGoodsReceiveResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsReceive>(goodsReceiveFromDb)
            };
        }

    }
}
