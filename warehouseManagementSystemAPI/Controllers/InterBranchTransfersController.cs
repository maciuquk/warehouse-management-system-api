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
    public class InterBranchTransfersController : ApiControllerBase
    {
        public InterBranchTransfersController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllInterBranchTransfers([FromQuery] GetInterBranchTransfersRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
        
        [HttpGet]
        [Route("{InterBranchTransferId}")]
        public async Task<IActionResult> GetById([FromRoute] int interBranchTransferId)
        {
            var request = new GetInterBranchTransferByIdRequest()
            {
                InterBranchTransferId = interBranchTransferId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddInterBranchTransfer([FromBody] AddInterBranchTransferRequest request)
        {
            return this.HandleRequest<AddInterBranchTransferRequest, AddInterBranchTransferResponse>(request);
        }

        [HttpDelete]
        [Route("{mmId}")]
        public async Task<IActionResult> DeleteInterBranchTransfer([FromRoute] int interBranchTransferId)
        {
            var idRequest = new DeleteInterBranchTransferRequest()
            {
                Id = interBranchTransferId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutInterBranchTransfer([FromQuery] PutInterBranchTransferRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }

}
