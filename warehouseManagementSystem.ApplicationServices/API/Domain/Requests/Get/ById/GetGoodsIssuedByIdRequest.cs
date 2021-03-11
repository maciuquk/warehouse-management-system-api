using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetGoodsIssuedByIdRequest : IRequest<GetGoodsIssuedByIdResponse>
    {
        public int GoodsIssuedId { get; set; }
    }
}
