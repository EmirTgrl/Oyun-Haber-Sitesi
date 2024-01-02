using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik boş bırakılamaz");
            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih boş bırakılamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
        }
    }
}
