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
    public class DeleteGoodsIssuedHandler : IRequestHandler<DeleteGoodsIssuedRequest, DeleteGoodsIssuedResponse>
    {
        private readonly ICommandExecutor commandExecutor;
        private readonly IMapper mapper;

        public DeleteGoodsIssuedHandler(ICommandExecutor commandExecutor, IMapper mapper)
        {
            this.commandExecutor = commandExecutor;
            this.mapper = mapper;
        }

        public async Task<DeleteGoodsIssuedResponse> Handle(DeleteGoodsIssuedRequest request, CancellationToken cancellationToken)
        {
            var goodsIssued = this.mapper.Map<GoodsIssued>(request);
            var command = new DeleteGoodsIssuedCommand() { Parameter = goodsIssued };
            var goodsIssuedFromDb = await this.commandExecutor.Execute(command);

            return new DeleteGoodsIssuedResponse()
            {
                Data = this.mapper.Map<Domain.Models.GoodsIssued>(goodsIssuedFromDb)
            };
        }
    }
}

