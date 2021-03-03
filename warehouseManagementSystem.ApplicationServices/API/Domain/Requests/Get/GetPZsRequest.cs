using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class GetPZsRequest : IRequest<GetPZsResponse>
    {
    }
}
