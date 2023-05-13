using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Bu alan boş bırakılamaz");

            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
            RuleFor(x => x.Content).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");

            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter giriniz");
            RuleFor(x => x.Content).MaximumLength(300).WithMessage("Lütfen en fazla 300 karakter giriniz");
        }
    }
}
