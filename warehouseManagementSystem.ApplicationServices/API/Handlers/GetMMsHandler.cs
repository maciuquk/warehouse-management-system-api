using AutoMapper;
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
        private readonly IMapper mapper;

        public GetMMsHandler(IRepository<DataAcces.Entities.MM> MMRepository, IMapper mapper)
        {
            this.MMRepository = MMRepository;
            this.mapper = mapper;
        }
        public async Task<GetMMsResponse> Handle(GetMMsRequest request, CancellationToken cancellationToken)
        {
            var MMs = await this.MMRepository.GetAll();
            var mappedMMs = this.mapper.Map<List<Domain.Models.MM>>(MMs);

            var response = new GetMMsResponse()
            {
                Data = mappedMMs
            };
            return response;
        }

    }
}
