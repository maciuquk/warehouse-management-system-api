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
        public GetPlacesHandler (IRepository<DataAcces.Entities.Place> PlacesRepository)
        {
            this.PlacesRepository = PlacesRepository;
        }
        public Task<GetPlacesResponse> Handle(GetPlacesRequest request, CancellationToken cancellationToken)
        {
            var places = this.PlacesRepository.GetAll();
            var domainPlaces = places.Select(n => new Domain.Models.Place()
            {
                Id = n.Id,
                PositionX = n.PositionX,
                PositionY = n.PositionY,
                MaxCapacity = n.MaxCapacity,
                CurrentOccupied = n.CurrentOccupied,
                Items = n.Items
            });

            var response = new GetPlacesResponse()
            {
                Data = domainPlaces.ToList()
            };
            return Task.FromResult(response);
        }

    }
}
