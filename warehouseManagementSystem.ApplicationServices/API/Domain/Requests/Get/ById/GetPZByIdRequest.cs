using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetPZByIdRequest : IRequest<GetPZByIdResponse>
    {
        public int PZId { get; set; }
    }
}
