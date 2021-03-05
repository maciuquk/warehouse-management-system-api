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
    public class GetMMByIdHandler : IRequestHandler<GetMMByIdRequest, GetMMByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetMMByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetMMByIdResponse> Handle(GetMMByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetMMQuery()
            {
                Id = request.MMId
            };

            var mm = await this.queryExecutor.Execute(query);

            var mappedMM = this.mapper.Map<Domain.Models.MM>(mm);

            var response = new GetMMByIdResponse()
            {
                Data = mappedMM
            };

            return response;
        }
    }
}
