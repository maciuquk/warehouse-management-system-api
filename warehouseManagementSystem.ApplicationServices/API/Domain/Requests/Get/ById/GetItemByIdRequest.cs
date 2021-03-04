using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Responses.ById;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Get
{
    public class GetItemByIdRequest : IRequest<GetItemByIdResponse>
    {
        public int ItemId { get; set; }
    }
}
