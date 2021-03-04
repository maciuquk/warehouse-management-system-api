using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain
{
    public class GetMMsRequest : IRequest<GetMMsResponse>
    {
        public string Number { get; set; }
    }
}
