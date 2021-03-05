using MediatR;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
    public class GetItemsRequest : IRequest<GetItemsResponse>
    {
        public string Name{ get; set; }
    } 
    
}
