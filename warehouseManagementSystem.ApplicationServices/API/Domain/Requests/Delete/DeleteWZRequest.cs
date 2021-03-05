using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteWZRequest : IRequest<DeleteWZResponse>
    {
        public int Id { get; set; }
    }
}
