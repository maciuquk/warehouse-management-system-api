using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;

namespace warehouseManagementSystem.ApplicationServices.API.Validators
{
    public class AddGoodsIssuedValidator : AbstractValidator<AddGoodsIssuedRequest>
    {
        public AddGoodsIssuedValidator()
        {

        }
    }
}
