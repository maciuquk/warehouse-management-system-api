using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutPlaceRequest : IRequest<PutPlaceResponse>
    {
        public int Id { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentOccupied { get; set; }
    }
}
