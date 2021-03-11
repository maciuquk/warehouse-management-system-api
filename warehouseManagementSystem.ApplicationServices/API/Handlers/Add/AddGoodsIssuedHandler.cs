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
    public class AddGoodsIssuedHandler : IRequestHandler<AddGoodsIssuedRequest, AddGoodsIssuedResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public AddGoodsIssuedHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<AddGoodsIssuedResponse> Handle(AddGoodsIssuedRequest request, CancellationToken cancellationToken)
        {
            var goodsIssued = this.mapper.Map<GoodsIssued>(request);
            var command = new AddGoodsIssuedCommand() { Parameter = goodsIssued };
            var goodsIssuedFromDb = await this.commandExecutor.Execute(command);

            return new AddGoodsIssuedResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsIssued>(goodsIssuedFromDb)
            };
        }
    }
}
