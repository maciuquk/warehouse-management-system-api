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
    public class GoodsReceivesController : ControllerBase
    {
        private readonly IMediator mediator;

        public GoodsReceivesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllGoodsReceives([FromQuery] GetGoodsReceivesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{goodsReceiveId}")]
        public async Task<IActionResult> GetById([FromRoute] int goodsReceiveId)
        {
            var request = new GetGoodsReceiveByIdRequest()
            {
                GoodsReceiveId = goodsReceiveId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddGoodsReceive([FromBody] AddGoodsReceiveRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{goodsReceiveId}")]
        public async Task<IActionResult> DeleteGoodsReceive([FromRoute] int goodsReceiveId)
        {
            var idRequest = new DeleteGoodsReceiveRequest()
            {
                Id = goodsReceiveId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();

        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutGoodsReceive([FromBody] PutGoodsReceiveRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
