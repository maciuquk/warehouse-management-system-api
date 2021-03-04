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
    public class GetWarehouseByIdHandler : IRequestHandler<GetWarehouseByIdRequest, GetWarehouseByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetWarehouseByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetWarehouseByIdResponse> Handle(GetWarehouseByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetWarehouseQuery()
            {
                Id = request.WarehouseId
            };

            var warehouse = await this.queryExecutor.Execute(query);

            var mappedWarehouse = this.mapper.Map<Domain.Models.Warehouse>(warehouse);

            var response = new GetWarehouseByIdResponse()
            {
                Data = mappedWarehouse
            };

            return response;
        }
    }
}
