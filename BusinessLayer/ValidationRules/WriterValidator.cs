using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Adınız kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Adınız kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Adınız kısmı boş geçilemez");
            RuleFor(x => x.WriterPassword).MinimumLength(5).WithMessage("En az 5 karakter girin.");
        }
    }
}
