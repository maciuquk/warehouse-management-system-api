using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetPlaceByIdRequest : IRequest<GetPlaceByIdResponse>
    {
        public int PlaceId { get; set; }
    }
}
