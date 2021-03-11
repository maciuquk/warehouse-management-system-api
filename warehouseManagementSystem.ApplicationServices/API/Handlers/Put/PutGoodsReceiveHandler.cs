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
    public class PutGoodsReceiveHandler : IRequestHandler<PutGoodsReceiveRequest, PutGoodsReceiveResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutGoodsReceiveHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutGoodsReceiveResponse> Handle(PutGoodsReceiveRequest request, CancellationToken cancellationToken)
        {
            var goodsReceive = this.mapper.Map<GoodsReceive>(request);
            var command = new PutGoodsReceiveCommand() { Parameter = goodsReceive };
            var goodsReceiveFromDb = await this.commandExecutor.Execute(command);

            return new PutGoodsReceiveResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsReceive>(goodsReceiveFromDb)
            };
        }
    }
}
