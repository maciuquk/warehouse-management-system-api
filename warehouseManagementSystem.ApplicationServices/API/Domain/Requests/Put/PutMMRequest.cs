using MediatR;
using System;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutMMRequest : IRequest<PutMMResponse>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
    }
}
