using MediatR;
using System;

namespace warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add
{
    public class AddGoodsReceiveRequest : IRequest<AddGoodsReceiveResponse>
    {

        public string Number { get; set; }
        public DateTime Date { get; set; }
        //public List<Item> Items { get; set; }
    }
}
