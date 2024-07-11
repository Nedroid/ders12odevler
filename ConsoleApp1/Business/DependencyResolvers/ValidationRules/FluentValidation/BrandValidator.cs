using FluentValidation;
using RecapProjectCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Business.DependencyResolvers.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).MinimumLength(2).MaximumLength(15);
            RuleFor(b => b.Name).NotEmpty();
        }
    }
}
