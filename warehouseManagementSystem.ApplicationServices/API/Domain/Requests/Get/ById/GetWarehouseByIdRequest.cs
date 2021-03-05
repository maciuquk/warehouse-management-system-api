using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetWarehouseByIdRequest : IRequest<GetWarehouseByIdResponse>
    {
        public int WarehouseId { get; set; }
    }
}
