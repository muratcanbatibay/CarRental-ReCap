using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
   public class CreditCardValidator:AbstractValidator<CreditCard>
    {


        public CreditCardValidator()
        {

            RuleFor(p => p.CardNumber).MaximumLength(13);
            RuleFor(p => p.CCV).MaximumLength(3).NotEmpty();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
        }


    }
}
