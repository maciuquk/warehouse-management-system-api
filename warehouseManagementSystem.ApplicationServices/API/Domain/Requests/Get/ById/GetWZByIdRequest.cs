using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetWZByIdRequest : IRequest<GetWZByIdResponse>
    {
        public int WZId { get; set; }
    }
}
