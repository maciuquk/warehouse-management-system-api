using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests
{
    public class AddItemRequest : IRequest<AddItemResponse>
    {
        public string Name { get; set; }
        //tutaj dodać pozostałe property
    }
}
