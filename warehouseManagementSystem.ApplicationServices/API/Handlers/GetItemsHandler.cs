using AutoMapper;
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
        private readonly IMapper mapper;

        public GetItemsHandler(IRepository<DataAcces.Entities.Item> itemRepository, IMapper mapper)
        {
            this.itemRepository = itemRepository;
            this.mapper = mapper;
        }
        public Task<GetItemsResponse> Handle(GetItemsRequest request, CancellationToken cancellationToken)
        {
            var items = this.itemRepository.GetAll();
            var mappedItems = this.mapper.Map<List<Domain.Models.Item>>(items);

            var response = new GetItemsResponse()
            {
                Data = mappedItems
            };
            return Task.FromResult(response);
        }
    }
}
