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
    public class PutGoodsIssuedHandler : IRequestHandler<PutGoodsIssuedRequest, PutGoodsIssuedResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;

        public PutGoodsIssuedHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }
        public async Task<PutGoodsIssuedResponse> Handle(PutGoodsIssuedRequest request, CancellationToken cancellationToken)
        {
            var goodsIssued = this.mapper.Map<GoodsIssued>(request);
            var command = new PutGoodsIssuedCommand() { Parameter = goodsIssued };
            var goodsIssuedFromDb = await this.commandExecutor.Execute(command);

            return new PutGoodsIssuedResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsIssued>(goodsIssuedFromDb)
            };
        }
    }
}
