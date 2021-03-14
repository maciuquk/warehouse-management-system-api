using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warehouseManagementSystem.ApplicationServices.API.Domain.Requests.Add;

namespace warehouseManagementSystem.ApplicationServices.API.Validators
{
    public class AddPlaceValidator : AbstractValidator<AddPlaceRequest>
    {
        public AddPlaceValidator()
        {
            this.RuleFor(x => x.CurrentOccupied).GreaterThan(0).WithMessage("WRONG_VALUE");
            this.RuleFor(x => x.PositionX).GreaterThan(0).WithMessage("WRONG_VALUE");
            this.RuleFor(x => x.PositionY).GreaterThan(0).WithMessage("WRONG_VALUE");
            this.RuleFor(x => x.MaxCapacity).GreaterThan(0).WithMessage("WRONG_VALUE");
        }
    }
}
