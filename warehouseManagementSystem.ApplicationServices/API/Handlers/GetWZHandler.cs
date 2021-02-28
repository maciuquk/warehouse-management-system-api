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
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{

    public class GetWZHandler : IRequestHandler<GetWZRequest, GetWZResponse>
    {
        private readonly IRepository<DataAcces.Entities.WZ> WZRepository;
        public GetWZHandler(IRepository<DataAcces.Entities.WZ> WZRepository)
        {
            this.WZRepository = WZRepository;
        }
        public Task<GetWZResponse> Handle(GetWZRequest request, CancellationToken cancellationToken)
        {
            var wzs = this.WZRepository.GetAll();
            var domainWZs = wzs.Select(n => new Domain.Models.WZ()
            {
                Id = n.Id,
                Number = n.Number,
                Date = n.Date,
                Items = n.Items

            });

            var response = new GetWZResponse()
            {
                Data = domainWZs.ToList()
            };
            return Task.FromResult(response);
        }
    }
}

