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
    public class GetPlacesHandler : IRequestHandler<GetPlacesRequest, GetPlacesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQuerryExecutor queryExecutor;

        public GetPlacesHandler (IMapper mapper, IQuerryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }
        public async Task<GetPlacesResponse> Handle(GetPlacesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetPlacesQuery()
            {
                PositionX = request.PositionX
            };
            var places = await this.queryExecutor.Execute(query);

            var mappedPlaces = this.mapper.Map<List<Domain.Models.Place>>(places);

            var response = new GetPlacesResponse()
            {
                Data = mappedPlaces
            };
            return response;
        }

    }
}
