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
    public class GoodsIssuedsController : ControllerBase
    {
        private readonly IMediator mediator;

        public GoodsIssuedsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetById([FromRoute] int goodsIssuedId)
        {
            var request = new GetGoodsIssuedByIdRequest()
            {
                GoodsIssuedId = goodsIssuedId
            };

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{wzId}")]
        public async Task<IActionResult> GetAllGoodsIssueds([FromQuery] GetGoodsIssuedsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddGoodsIssued([FromBody] AddGoodsIssuedRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{goodsIssuedId}")]
        public async Task<IActionResult> DeleteGoodsIssued([FromRoute] int goodsIssuedId)
        {
            var idRequest = new DeleteGoodsIssuedRequest()
            {
                Id = goodsIssuedId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutGoodsIssued([FromBody] PutGoodsIssuedRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }

    
}



    
