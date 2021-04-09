using Entities.Concrete;
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
            RuleFor(p=>p.ProductName).MinimumLength(2);//en az 2 karakterli olmalı
            RuleFor(p=>p.ProductName).NotEmpty();//boş bırakılamaz
            RuleFor(p=>p.UnitPrice).NotEmpty();//boş bırakılamaz
            RuleFor(p=>p.UnitPrice).GreaterThan(0);//0 dan büyük olmalı
            RuleFor(p=>p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1);//kategori id si 1 olanların 10 dan büyük olmalı fiyatı
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");//Ürün isimleri A ile başlamalı
           
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
