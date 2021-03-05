using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetMMByIdRequest : IRequest<GetMMByIdResponse>
    {
        public int MMId { get; set; }
    }
}
