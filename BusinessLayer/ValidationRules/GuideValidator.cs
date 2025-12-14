using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rehber Adını Boş Geçemezsiniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Rehber Açıklamasını Giriniz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Rehber Görselini Giriniz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha kısa bir isim giriniz.");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 karakterden daha uzun bir isim giriniz.");
        }
    }
}
