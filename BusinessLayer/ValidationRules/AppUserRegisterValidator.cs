using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Username).MinimumLength(4).WithMessage("Kullancı adı en az 4 karakter olmalıdır");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullancı adı en fazla 20 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler aynı olmalıdır");
        }

    }
}
