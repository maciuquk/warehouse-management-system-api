using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.DataAcces;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetItemsHandler : IRequestHandler<GetItemsRequest, GetItemsResponse>
    {
        private readonly IRepository<DataAcces.Entities.Item> itemRepository;
        public GetItemsHandler(IRepository<DataAcces.Entities.Item> itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        public Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
            //operacja pobrania itemsów
            var items = this.itemRepository.GetAll();
            var domainItems = items.Select(n => new Domain.Models.Item()
            {
                Id = n.Id,
                Name = n.Name,
                Quantity = n.Quantity,
                PhotoUrl = n.PhotoUrl,
                PZs = n.PZs,
                WZs = n.WZs,
                MMs = n.MMs,
                Places = n.Places,
                Warehouses = n.Warehouses
            });

            var response = new GetItemsResponse()
            {
                Data = domainItems.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
