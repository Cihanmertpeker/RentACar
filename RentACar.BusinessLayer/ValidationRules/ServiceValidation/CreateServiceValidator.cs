using FluentValidation;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.ValidationRules.ServiceValidation
{
    public class CreateServiceValidator:AbstractValidator<Service>
    {
        public CreateServiceValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Lütfen Hizmet Başlığı giriniz!");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Lütfen Açıklamayı giriniz!");
            RuleFor(x=>x.Icon).NotEmpty().WithMessage("Lütfen Ikon Url giriniz!");
            RuleFor(x=>x.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karekter veri girişi yapınız!");
            RuleFor(x=>x.Title).MaximumLength(30).WithMessage("Lütfen en fazla 30 karekter veri girişi yapınız!");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen en az 5 karekter veri girişi yapınız!");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Lütfen en fazla 200 karekter veri girişi yapınız!");


        }
    }
}
