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

    public class GetGoodsIssuedsHandler : IRequestHandler<GetGoodsIssuedsRequest, GetGoodsIssuedsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetGoodsIssuedsHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetGoodsIssuedsResponse> Handle(GetGoodsIssuedsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetGoodsIssuedsQuery()
            {
                Number = request.Number
            };
            var goodsIssueds = await this.queryExecutor.Execute(query);

            var mappedGoodsIssueds = this.mapper.Map<List<Domain.Models.GoodsIssued>>(goodsIssueds);

            var response = new GetGoodsIssuedsResponse()
            {
                Data = mappedGoodsIssueds
            };
            return response;
        }
    }
}

