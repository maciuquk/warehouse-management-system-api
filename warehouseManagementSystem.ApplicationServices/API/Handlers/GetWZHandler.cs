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
using warehouseManagementSystem.DataAcces.Entities;

namespace warehouseManagementSystem.ApplicationServices.API.Handlers
{

    public class GetWZHandler : IRequestHandler<GetWZRequest, GetWZResponse>
    {
        private readonly IRepository<DataAcces.Entities.WZ> WZRepository;
        private readonly IMapper mapper;

        public GetWZHandler(IRepository<DataAcces.Entities.WZ> WZRepository, IMapper mapper)
        {
            this.WZRepository = WZRepository;
            this.mapper = mapper;
        }
        public async Task<GetWZResponse> Handle(GetWZRequest request, CancellationToken cancellationToken)
        {
            var wzs = await this.WZRepository.GetAll();
            var mappedWZ = this.mapper.Map<List<Domain.Models.WZ>>(wzs);

            var response = new GetWZResponse()
            {
                Data = mappedWZ
            };
            return response;
        }
    }
}

