using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetPZsRequest : IRequest<GetPZsResponse>
    {
        public string Number { get; set; }

    }
}
