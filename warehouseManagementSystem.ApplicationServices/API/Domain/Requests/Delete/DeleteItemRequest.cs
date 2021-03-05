using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteItemRequest : IRequest<DeleteItemResponse>
    {
        public int Id { get; set; }
    }
}
