using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;
using warehouseManagementSystem.DataAcces;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{
    public class GetPZHandler : IRequestHandler<GetPZRequest, GetPZResponse>
    {
        private readonly IRepository<DataAcces.Entities.PZ> PZRepository;
        public GetPZHandler(IRepository<DataAcces.Entities.PZ> PZRepository)
        {
            this.PZRepository = PZRepository;
        }
        public Task<GetPZResponse> Handle(GetPZRequest request, CancellationToken cancellationToken)
        {
            var pzs = this.PZRepository.GetAll();
            var domainPZs = pzs.Select(n => new Domain.Models.PZ()
            {
                Id = n.Id,
                Number = n.Number,
                Date = n.Date,
                Items = n.Items
            });

            var response = new GetPZResponse()
            {
                Data = domainPZs.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
