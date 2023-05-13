using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("Bu alan boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu alan boş geçilemez");

            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.Title).MaximumLength(40).WithMessage("Lütfen en fazla 40 karakter giriniz");

            RuleFor(x => x.Content).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.Content).MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter giriniz");



        }
    }
}
