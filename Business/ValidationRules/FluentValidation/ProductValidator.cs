﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 30);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo(0);
        }
    }
}
