using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.Delete;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Delete
{
    public class DeleteWZRequest : IRequest<DeleteWZResponse>
    {
        public int Id { get; set; }
    }
}
