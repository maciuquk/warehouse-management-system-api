using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests;

namespace warehouseManagementSystem.ApplicationServices.API.Validators
{
    public class AddItemValidator : AbstractValidator<AddItemRequest>
    {
        public AddItemValidator()
        {
            this.RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("WRONG_VALUE");

        }
    }
}
