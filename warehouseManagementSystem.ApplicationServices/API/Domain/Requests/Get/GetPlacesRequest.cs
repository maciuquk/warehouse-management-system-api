using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
    public class GetPlacesRequest : IRequest<GetPlacesResponse>
    {
        public int PositionX { get; set; }
        //public int PositionY { get; set; }
    }
}
