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
    public class GetGoodsIssuedByIdHandler : IRequestHandler<GetGoodsIssuedByIdRequest, GetGoodsIssuedByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetGoodsIssuedByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetGoodsIssuedByIdResponse> Handle(GetGoodsIssuedByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetGoodsIssuedQuery()
            {
                Id = request.GoodsIssuedId
            };

            var goodsIssued = await this.queryExecutor.Execute(query);

            var mappedGoodsIssued = this.mapper.Map<Domain.Models.GoodsIssued>(goodsIssued);

            var response = new GetGoodsIssuedByIdResponse()
            {
                Data = mappedGoodsIssued
            };

            return response;
        }
    }
}
