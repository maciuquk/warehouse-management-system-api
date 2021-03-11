using MediatR;
using System;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Put;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Put
{
    public class PutInterBranchTransferRequest : IRequest<PutInterBranchTransferResponse>
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
    }
}
