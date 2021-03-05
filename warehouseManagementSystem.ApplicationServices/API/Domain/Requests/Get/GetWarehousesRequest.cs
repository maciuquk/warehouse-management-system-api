using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetWarehousesRequest : IRequest<GetWarehousesResponse>
    {
        public string Name { get; set; }

    }
}
