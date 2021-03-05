using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
    public class GetMMsRequest : IRequest<GetMMsResponse>
    {
        public string Number { get; set; }
    }
}
