using MediatR;
using System;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutGoodsReceiveRequest : IRequest<PutGoodsReceiveResponse>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
    }
}
