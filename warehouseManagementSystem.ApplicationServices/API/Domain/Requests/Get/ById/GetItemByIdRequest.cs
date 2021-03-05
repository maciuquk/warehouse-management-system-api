using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get
{
    public class GetItemByIdRequest : IRequest<GetItemByIdResponse>
    {
        public int ItemId { get; set; }
    }
}
