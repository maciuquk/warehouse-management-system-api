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
    public class DeleteGoodsReceiveHandler : IRequestHandler<DeleteGoodsReceiveRequest, DeleteGoodsReceiveResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteGoodsReceiveHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteGoodsReceiveResponse> Handle(DeleteGoodsReceiveRequest request, CancellationToken cancellationToken)
        {
            var goodsReceive = this.mapper.Map<GoodsReceive>(request);
            var command = new DeleteGoodsReceiveCommand() { Parameter = goodsReceive };
            var goodsReceiveFromDb = await this.commandExecutor.Execute(command);

            return new DeleteGoodsReceiveResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsReceive>(goodsReceiveFromDb)
            };
        }
    }
}

