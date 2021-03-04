using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{

    public class GetWZHandler : IRequestHandler<GetWZsRequest, GetWZsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetWZHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetWZsResponse> Handle(GetWZsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetWZsQuery()
            {
                Number = request.Number
            };
            var wzs = await this.queryExecutor.Execute(query);

            var mappedWZs = this.mapper.Map<List<Domain.Models.WZ>>(wzs);

            var response = new GetWZsResponse()
            {
                Data = mappedWZs
            };
            return response;
        }
    }
}

