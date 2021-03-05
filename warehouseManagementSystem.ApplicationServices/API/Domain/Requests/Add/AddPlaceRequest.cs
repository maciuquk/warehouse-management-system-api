using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add
{
    public class AddPlaceRequest : IRequest<AddPlaceResponse>
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentOccupied { get; set; }
        //public List<Item> Items { get; set; }
    }
}
