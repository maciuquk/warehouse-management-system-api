using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add
{
    public class AddWarehouseRequest : IRequest<AddWarehouseResponse>
    {
        public string Name { get; set; }
        //public List<Item> Items { get; set; }
    }
}
