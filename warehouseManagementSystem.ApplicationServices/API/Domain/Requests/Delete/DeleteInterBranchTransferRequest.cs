using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteInterBranchTransferRequest : IRequest<DeleteInterBranchTransferResponse>
    {
        public int Id { get; set; }
    }
}
