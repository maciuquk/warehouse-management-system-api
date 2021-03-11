using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
    public class GetInterBranchTransfersRequest : IRequest<GetInterBranchTransfersResponse>
    {
        public string Number { get; set; }
    }
}
