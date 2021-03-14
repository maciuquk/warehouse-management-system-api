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
    public class PlacesController : ApiControllerBase
    {
        public PlacesController(IMediator mediator) : base(mediator)
        {

        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllPlaces([FromQuery] GetPlacesRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpGet]
        [Route("{placeId}")]
        public async Task<IActionResult> GetById([FromRoute] int placeId)
        {
            var request = new GetPlaceByIdRequest()
            {
                PlaceId = placeId
            };
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddPlace([FromBody] AddPlaceRequest request)
        {
            return this.HandleRequest<AddPlaceRequest, AddPlaceResponse>(request);
        }

        [HttpDelete]
        [Route("{placeId}")]
        public async Task<IActionResult> DeletePlace([FromRoute] int placeId)
        {
            var idRequest = new DeletePlaceRequest()
            {
                Id = placeId
            };
            var idResponse = await this.mediator.Send(idRequest);
            return this.Ok();

        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> PutPlace([FromBody] PutPlaceRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

    }
}
