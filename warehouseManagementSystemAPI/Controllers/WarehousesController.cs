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
    public class WarehousesController : ControllerBase
    {
        private readonly IMediator mediator;

        public WarehousesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllWarehouses([FromQuery] GetWarehousesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{warehouseId}")]
        public async Task<IActionResult> GetById([FromRoute] int warehouseId)
        {
            var request = new GetWarehouseByIdRequest()
            {
                WarehouseId = warehouseId
            };

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddWarehouse([FromBody] AddWarehouseRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{warehouseId}")]
        public async Task<IActionResult> DeleteWarehouse([FromRoute] int warehouseId)
        {
            var idRequest = new DeleteWarehouseRequest()
            {
                Id = warehouseId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();

        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutWarehouse([FromBody] PutWarehouseRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
