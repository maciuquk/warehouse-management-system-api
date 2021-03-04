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
    public class GetWZByIdHandler : IRequestHandler<GetWZByIdRequest, GetWZByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetWZByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetWZByIdResponse> Handle(GetWZByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetWZQuery()
            {
                Id = request.WZId
            };

            var wz = await this.queryExecutor.Execute(query);

            var mappedWZ = this.mapper.Map<Domain.Models.WZ>(wz);

            var response = new GetWZByIdResponse()
            {
                Data = mappedWZ
            };

            return response;
        }
    }
}
