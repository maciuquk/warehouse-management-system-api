using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeletePlaceRequest : IRequest<DeletePlaceResponse>
    {
        public int Id { get; set; }
    }
}
