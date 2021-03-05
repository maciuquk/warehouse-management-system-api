using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteMMRequest : IRequest<DeleteMMResponse>
    {
        public int Id { get; set; }
    }
}
