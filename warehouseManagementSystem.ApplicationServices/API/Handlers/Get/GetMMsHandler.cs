using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetMMsHandler : IRequestHandler<GetMMsRequest, GetMMsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetMMsHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetMMsResponse> Handle(GetMMsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMMsQuery()
            {
                Number = request.Number
            }; 
            var mms = await this.queryExecutor.Execute(query);

            var mappedMMs = this.mapper.Map<List<Domain.Models.MM>>(mms);

            var response = new GetMMsResponse()
            {
                Data = mappedMMs
            };
            return response;
        }

    }
}
