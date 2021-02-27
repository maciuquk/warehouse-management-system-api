using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;

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
        }
    }
