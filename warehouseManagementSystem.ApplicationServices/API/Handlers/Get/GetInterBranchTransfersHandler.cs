using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.CQRS.Querries;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetInterBranchTransfersHandler : IRequestHandler<GetInterBranchTransfersRequest, GetInterBranchTransfersResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetInterBranchTransfersHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetInterBranchTransfersResponse> Handle(GetInterBranchTransfersRequest request, CancellationToken cancellationToken)
        {
            var query = new GetInterBranchTransfersQuery()
            {
            }; 
            var interBranchTransfers = await this.queryExecutor.Execute(query);

            var mappedInterBranchTransfers = this.mapper.Map<List<Domain.Models.InterBranchTransfer>>(interBranchTransfers);

            var response = new GetInterBranchTransfersResponse()
            {
                Data = mappedInterBranchTransfers
            };
            return response;
        }

    }
}
