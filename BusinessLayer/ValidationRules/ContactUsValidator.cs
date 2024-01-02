using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactUsValidator : AbstractValidator<ContactUs>
    {
        public ContactUsValidator()
        {
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Mesaj konusu boş bırakılamaz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş bırakılamaz");
        }
    }
}
