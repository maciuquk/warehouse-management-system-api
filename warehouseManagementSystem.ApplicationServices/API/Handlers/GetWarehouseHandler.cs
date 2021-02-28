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
        public GetWarehouseHandler(IRepository<DataAcces.Entities.Warehouse> WarehouseRepository)
        {
            this.WarehouseRepository = WarehouseRepository;
        }
        public Task<GetWarehouseResponse> Handle(GetWarehouseRequest request, CancellationToken cancellationToken)
        {
            var warehouses = this.WarehouseRepository.GetAll();
            var domainWarehouses = warehouses.Select(n => new Domain.Models.Warehouse()
            {
                Id = n.Id,
                Name = n.Name,
                Items = n.Items
            });

            var response = new GetWarehouseResponse()
            {
                Data = domainWarehouses.ToList()
            };
            return Task.FromResult(response);
        }
    }

}
