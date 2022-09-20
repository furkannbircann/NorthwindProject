﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0).When(p => p.CategoryID == 1);

            //RuleFor(p => p.ProductName).Must(StartWithF).WithMessage("Ürünler F harfi ile başlamalı ! ");
        }

        //private bool StartWithF(string arg)
        //{
        //    return arg.StartsWith("F");
        //}
    }
}
