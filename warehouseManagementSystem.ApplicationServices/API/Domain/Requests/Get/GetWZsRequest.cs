using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetWZsRequest : IRequest<GetWZsResponse>
    {
        public string Number { get; set; }

    }
}
