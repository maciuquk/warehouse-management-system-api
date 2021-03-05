using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeletePZRequest : IRequest<DeletePZResponse>
    {
        public int Id { get; set; }
    }
}
