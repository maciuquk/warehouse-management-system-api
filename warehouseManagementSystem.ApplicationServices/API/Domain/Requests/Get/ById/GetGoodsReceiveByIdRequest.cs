using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetGoodsReceiveByIdRequest : IRequest<GetGoodsReceiveByIdResponse>
    {
        public int GoodsReceiveId { get; set; }
    }
}
