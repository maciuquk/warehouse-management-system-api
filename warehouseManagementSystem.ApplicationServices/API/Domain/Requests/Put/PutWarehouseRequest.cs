using MediatR;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutWarehouseRequest : IRequest<PutWarehouseResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
