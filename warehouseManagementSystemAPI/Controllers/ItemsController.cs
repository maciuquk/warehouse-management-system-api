using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.DataAcces;
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        //private readonly IRepository<Item> itemRepository;

        //public ItemsController(IRepository<Item> itemRepository)
        //{
        //    this.itemRepository = itemRepository;
        //}

        //[HttpGet]
        //[Route("")]
        //public IEnumerable<Item> GetAllItems() => this.itemRepository.GetAll();

        //[HttpGet]
        //[Route("{itemId}")]
        //public Item GetItemById(int itemId) => this.itemRepository.GetById(itemId);

        private readonly IMediator mediator;

        public ItemsController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllItems([FromQuery] GetItemsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddItem([FromBody] AddItemRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}
