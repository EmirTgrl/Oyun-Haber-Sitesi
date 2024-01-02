using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NewsValidator : AbstractValidator<News>
    {
        public NewsValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Haber açıklaması boş bırakılamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Haber başlığı boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş bırakılamaz");
            RuleFor(x => x.GameName).NotEmpty().WithMessage("Oyun adı boş bırakılamaz");
        }
    }
}
