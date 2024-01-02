using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GameTypeValidator:AbstractValidator<GameType>
    {
        public GameTypeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Oyun adı boş bırakılamaz");
        }
    }
}
