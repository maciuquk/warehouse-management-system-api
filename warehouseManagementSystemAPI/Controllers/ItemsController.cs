using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ApiControllerBase
    {
        public ItemsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest request)
        {
            return this.HandleRequest<GetItemsRequest, GetItemsResponse>(request);
        }

        [HttpGet]
        [Route("{itemId}")]
        public async Task<IActionResult> GetById ([FromRoute] int itemId)
        {
            var request = new GetItemByIdRequest()
            {
                ItemId = itemId
            };

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddItem([FromBody] AddItemRequest request)
        {
            return this.HandleRequest<AddItemRequest, AddItemResponse>(request);
        }

        [HttpDelete]
        [Route("{itemId}")]
        public async Task<IActionResult> DeleteItem([FromRoute] int itemId)
        {
            var idRequest = new DeleteItemRequest()
            {
                Id = itemId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();
        }
        
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutItem([FromQuery] PutItemRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
