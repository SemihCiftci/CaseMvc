﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior : AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
           RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez");
        }
    }
}
