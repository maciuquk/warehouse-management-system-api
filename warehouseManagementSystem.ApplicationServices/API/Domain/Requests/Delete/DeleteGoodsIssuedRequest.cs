using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteGoodsIssuedRequest : IRequest<DeleteGoodsIssuedResponse>
    {
        public int Id { get; set; }
    }
}
