using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.DataAcces;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetPlacesHandler : IRequestHandler<GetPlacesRequest, GetPlacesResponse>
    {
        private readonly IRepository<DataAcces.Entities.Place> PlacesRepository;
        private readonly IMapper mapper;

        public GetPlacesHandler (IRepository<DataAcces.Entities.Place> PlacesRepository, IMapper mapper)
        {
            this.PlacesRepository = PlacesRepository;
            this.mapper = mapper;
        }
        public async Task<GetPlacesResponse> Handle(GetPlacesRequest request, CancellationToken cancellationToken)
        {
            var places = await this.PlacesRepository.GetAll();
            var mappedPlaces = this.mapper.Map<List<Domain.Models.Place>>(places);

            var response = new GetPlacesResponse()
            {
                Data = mappedPlaces
            };
            return response;
        }

    }
}
