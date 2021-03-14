using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get.ById;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsIssuedsController : ApiControllerBase
    {
        public GoodsIssuedsController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GoodsIssueds([FromQuery] GetGoodsIssuedsRequest request)
        {
            return this.HandleRequest<GetGoodsIssuedsRequest, GetGoodsIssuedsResponse>(request);
        }

        [HttpGet]
        [Route("{itemId}")]
        public async Task<IActionResult> GetById([FromRoute] int GoodsIssuedId)
        {
            var request = new GetGoodsIssuedByIdRequest()
            {
                GoodsIssuedId = GoodsIssuedId
            };

            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddGoodsIssued([FromBody] AddGoodsIssuedRequest request)
        {
            return this.HandleRequest<AddGoodsIssuedRequest, AddGoodsIssuedResponse>(request);
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



    
