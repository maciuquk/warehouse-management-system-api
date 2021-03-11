using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetGoodsIssuedsRequest : IRequest<GetGoodsIssuedsResponse>
    {
        public string Number { get; set; }

    }
}
