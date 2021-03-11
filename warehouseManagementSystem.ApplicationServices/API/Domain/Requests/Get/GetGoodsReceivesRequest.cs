using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetGoodsReceivesRequest : IRequest<GetGoodsReceivesResponse>
    {
        public string Number { get; set; }

    }
}
