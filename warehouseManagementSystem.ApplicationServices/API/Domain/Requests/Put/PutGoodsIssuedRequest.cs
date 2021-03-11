using MediatR;
using System;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutGoodsIssuedRequest : IRequest<PutGoodsIssuedResponse>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
    }
}
