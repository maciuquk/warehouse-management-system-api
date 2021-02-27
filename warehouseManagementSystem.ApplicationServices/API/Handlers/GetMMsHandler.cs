using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain;
using warehouseManagementSystem.ApplicationServices.API.Domain.Models;
using warehouseManagementSystem.DataAcces;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetMMsHandler : IRequestHandler<GetMMsRequest, GetMMsResponse>
    {
        private readonly IRepository<DataAcces.Entities.MM> MMRepository;
        public GetMMsHandler(IRepository<DataAcces.Entities.MM> MMRepository)
        {
            this.MMRepository = MMRepository;
        }
        public Task<GetMMsResponse> Handle(GetMMsRequest request, CancellationToken cancellationToken)
        {
            //operacja pobrania itemsów
            var MMs = this.MMRepository.GetAll();
            var domainMMs = MMs.Select(n => new Domain.Models.MM()
            {
                Id = n.Id,
                Number = n.Number,
                Date = n.Date,
                Items = n.Items
            });

            var response = new GetMMsResponse()
            {
                Data = domainMMs.ToList()
            };
            return Task.FromResult(response);
        }

    }
}
