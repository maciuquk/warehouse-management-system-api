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
    public class GetPlaceByIdHandler : IRequestHandler<GetPlaceByIdRequest, GetPlaceByIdResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetPlaceByIdHandler(IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetPlaceByIdResponse> Handle(GetPlaceByIdRequest request, CancellationToken cancellationToken)
        {
            var query = new GetPlaceQuery()
            {
                Id = request.PlaceId
            };

            var place = await this.queryExecutor.Execute(query);

            var mappedPlace = this.mapper.Map<Domain.Models.Place>(place);

            var response = new GetPlaceByIdResponse()
            {
                Data = mappedPlace
            };

            return response;
        }
    }
}
