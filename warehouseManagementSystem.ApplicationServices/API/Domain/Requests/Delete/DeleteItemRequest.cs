using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteItemRequest : IRequest<DeleteItemResponse>
    {
        public int Id { get; set; }
    }
}
