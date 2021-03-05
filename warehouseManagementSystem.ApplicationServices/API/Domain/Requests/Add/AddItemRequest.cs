using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class AddItemRequest : IRequest<AddItemResponse>
    {
        public string Name { get; set; }
    }
}
