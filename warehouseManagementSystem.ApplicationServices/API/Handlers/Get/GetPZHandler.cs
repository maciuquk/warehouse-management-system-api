using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetPZHandler : IRequestHandler<GetPZsRequest, GetPZsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetPZHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetPZsResponse> Handle(GetPZsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetPZsQuery()
            {
                Number = request.Number
            };
            var pzs = await this.queryExecutor.Execute(query);

            var mappedPZs = this.mapper.Map<List<Domain.Models.PZ>>(pzs);

            var response = new GetPZsResponse()
            {
                Data = mappedPZs
            };
            return response;
        }
    }
}
