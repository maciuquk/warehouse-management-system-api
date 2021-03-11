using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.GetById
{
    public class GetGoodsReceiveByIdHandler : IRequestHandler<GetGoodsReceiveByIdRequest, GetGoodsReceiveByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetGoodsReceiveByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetGoodsReceiveByIdResponse> Handle(GetGoodsReceiveByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetGoodsReceiveQuery()
            {
                Id = request.GoodsReceiveId
            };

            var goodsReceive = await this.queryExecutor.Execute(query);

            var mappedGoodsReceive = this.mapper.Map<Domain.Models.GoodsReceive>(goodsReceive);

            var response = new GetGoodsReceiveByIdResponse()
            {
                Data = mappedGoodsReceive
            };

            return response;
        }
    }
}
