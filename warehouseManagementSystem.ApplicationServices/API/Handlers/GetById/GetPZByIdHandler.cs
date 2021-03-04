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
    public class GetPZByIdHandler : IRequestHandler<GetPZByIdRequest, GetPZByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetPZByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetPZByIdResponse> Handle(GetPZByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetPZQuery()
            {
                Id = request.PZId
            };

            var pz = await this.queryExecutor.Execute(query);

            var mappedPZ = this.mapper.Map<Domain.Models.PZ>(pz);

            var response = new GetPZByIdResponse()
            {
                Data = mappedPZ
            };

            return response;
        }
    }
}
