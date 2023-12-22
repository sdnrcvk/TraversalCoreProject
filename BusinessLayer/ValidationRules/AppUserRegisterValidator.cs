using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator() 
        { 
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("Kullanıcı alanı boş geçilemez");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalıdır");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("Kullanıcı adı en fazla 20 karakter olmalıdır");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor");

        }
    }
}
