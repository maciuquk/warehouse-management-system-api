using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers.GetById
{
    public class GetInterBranchTransferByIdHandler : IRequestHandler<GetInterBranchTransferByIdRequest, GetInterBranchTransferByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetInterBranchTransferByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetInterBranchTransferByIdResponse> Handle(GetInterBranchTransferByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetInterBranchTransferQuery()
            {
                Id = request.InterBranchTransferId
            };

            var interBranchTransfer = await this.queryExecutor.Execute(query);

            var mappedInterBranchTransfer = this.mapper.Map<Domain.Models.InterBranchTransfer>(interBranchTransfer);

            var response = new GetInterBranchTransferByIdResponse()
            {
                Data = mappedInterBranchTransfer
            };

            return response;
        }
    }
}
