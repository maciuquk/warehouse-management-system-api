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

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetWarehouseHandler : IRequestHandler<GetWarehousesRequest, GetWarehousesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetWarehouseHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetWarehousesResponse> Handle(GetWarehousesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetWarehousesQuery()
            {
                Name = request.Name
            };
            var warehouses = await this.queryExecutor.Execute(query);

            var mappedWarehouses = this.mapper.Map<List<Domain.Models.Warehouse>>(warehouses);

            var response = new GetWarehousesResponse()
            {
                Data = mappedWarehouses
            };
            return response;
        }
    }

}
