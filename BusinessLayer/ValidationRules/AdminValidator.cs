using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AdminValidator : AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.AdminUserName).NotEmpty().WithMessage("Admin  Kullanıcı(Mail) Adını Boş Geçemezsiniz");
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage("Şifreyi Boş Geçemezsiniz");
            RuleFor(x => x.AdminRole).NotEmpty().WithMessage("Yetkilendirmeyi Boş Geçemezsiniz");
            RuleFor(x => x.AdminUserName).MinimumLength(16).WithMessage("Lütfen Kullanıcı(Mail) adını doğru girdiğinizden emin olunuz");
            RuleFor(x => x.AdminPassword).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın");
            //RuleFor(x => x.CategoryStatus).Must(4).WithMessage("aÇIKLAMA");
        }
    }
}
