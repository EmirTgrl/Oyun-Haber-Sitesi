using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.Client).NotEmpty().WithMessage("Yazar adı boş bırakılamaz");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Yorum alanı boş bırakılamaz");
        }
    }
}
