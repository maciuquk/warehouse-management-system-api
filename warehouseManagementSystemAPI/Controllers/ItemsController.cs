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
    public class ItemsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ItemsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
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
        public async Task<IActionResult> AddItem([FromBody] AddItemRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
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
        [Route("{itemId}")]
        public async Task<IActionResult> PutItem([FromRoute] int itemId, [FromBody] PutItemRequest request)
        {
            var idRequest = new PutItemRequest()
            {
                Id = itemId
            };
            var idResponse = await this.mediator.Send(idRequest);

            // jak to połączyć?

            var response = await this.mediator.Send(request);
            return this.Ok(response);

        }
    }
}
