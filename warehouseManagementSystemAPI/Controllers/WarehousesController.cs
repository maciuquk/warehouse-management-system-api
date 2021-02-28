using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;

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
        public async Task<IActionResult> GetAllWarehouses([FromQuery] GetWarehouseRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
