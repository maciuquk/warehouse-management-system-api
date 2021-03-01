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
    public class GetWarehouseHandler : IRequestHandler<GetWarehouseRequest, GetWarehouseResponse>
    {
        private readonly IRepository<DataAcces.Entities.Warehouse> WarehouseRepository;
        private readonly IMapper mapper;

        public GetWarehouseHandler(IRepository<DataAcces.Entities.Warehouse> WarehouseRepository, IMapper mapper)
        {
            this.WarehouseRepository = WarehouseRepository;
            this.mapper = mapper;
        }
        public async Task<GetWarehouseResponse> Handle(GetWarehouseRequest request, CancellationToken cancellationToken)
        {
            var warehouses = await this.WarehouseRepository.GetAll();
            var mappedWarehouses = this.mapper.Map<List<Domain.Models.Warehouse>>(warehouses);

            var response = new GetWarehouseResponse()
            {
                Data = mappedWarehouses
            };
            return response;
        }
    }

}
