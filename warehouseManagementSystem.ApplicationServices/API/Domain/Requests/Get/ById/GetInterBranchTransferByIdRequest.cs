using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById
{
    public class GetInterBranchTransferByIdRequest : IRequest<GetInterBranchTransferByIdResponse>
    {
        public int InterBranchTransferId { get; set; }
    }
}
