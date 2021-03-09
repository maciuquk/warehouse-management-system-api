using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PZsController : ControllerBase
    {
        private readonly IMediator mediator;

        public PZsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllPZs([FromQuery] GetPZsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{pzId}")]
        public async Task<IActionResult> GetById([FromRoute] int pzId)
        {
            var request = new GetPZByIdRequest()
            {
                PZId = pzId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddPZ([FromBody] AddPZRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutPZ([FromBody] PutPZRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{pzId}")]
        public async Task<IActionResult> DeletePZ([FromRoute] int pzId)
        {
            var idRequest = new DeleteItemRequest()
            {
                Id = pzId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();

        }
    }
}
