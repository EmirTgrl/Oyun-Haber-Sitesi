using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yorum içeriği boş bırakılamaz");
            RuleFor(x => x.CommentUser).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz");
        }
    }
}
