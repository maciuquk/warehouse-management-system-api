using AutoMapper;
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
        private readonly IMapper mapper;

        public GetPZHandler(IRepository<DataAcces.Entities.PZ> PZRepository, IMapper mapper)
        {
            this.PZRepository = PZRepository;
            this.mapper = mapper;
        }
        public Task<GetPZResponse> Handle(GetPZRequest request, CancellationToken cancellationToken)
        {
            var pzs = this.PZRepository.GetAll();
            var mappedPZs = this.mapper.Map<List<Domain.Models.PZ>>(pzs);

            var response = new GetPZResponse()
            {
                Data = mappedPZs.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
