using FluentValidation;
using GenericRepository.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.API.Validators
{
    public class CategoriesValidator : AbstractValidator<CategoryDTO>
    {
        public CategoriesValidator()
        {
            RuleFor(a => a.CategoryName)
              .NotEmpty()
              .MaximumLength(50);
            // .WithMessage("'Artist Id' must not be 0.");
        }
    }
}
