using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;

namespace warehouseManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MMsController : ControllerBase
    {
        private readonly IMediator mediator;

        public MMsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllMMs([FromQuery] GetMMsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        
        [HttpGet]
        [Route("{mmId}")]
        public async Task<IActionResult> GetById([FromRoute] int mmId)
        {
            var request = new GetMMByIdRequest()
            {
                MMId = mmId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddMM([FromBody] AddMMRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
               
        [HttpDelete]
        [Route("{mmId}")]
        public async Task<IActionResult> DeleteMM([FromRoute] int mmId)
        {
            var idRequest = new DeleteMMRequest()
            {
                Id = mmId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutMM([FromQuery] PutMMRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }

}
