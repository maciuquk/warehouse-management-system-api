using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetGoodsReceivesHandler : IRequestHandler<GetGoodsReceivesRequest, GetGoodsReceivesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetGoodsReceivesHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetGoodsReceivesResponse> Handle(GetGoodsReceivesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetGoodsReceivesQuery()
            {
            };
            var goodsReceives = await this.queryExecutor.Execute(query);

            var mappedGoodsReceives = this.mapper.Map<List<Domain.Models.GoodsReceive>>(goodsReceives);

            var response = new GetGoodsReceivesResponse()
            {
                Data = mappedGoodsReceives
            };
            return response;
        }
    }
}
