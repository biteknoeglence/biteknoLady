using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.ArticleTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez");
            RuleFor(x => x.ArticleContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez");
            RuleFor(x => x.ArticleImage).NotEmpty().WithMessage("Blog görseli boş geçilemez");
            RuleFor(x => x.ArticleTitle).MinimumLength(5).WithMessage("En az 5 karakter girin.");
            RuleFor(x => x.ArticleTitle).MaximumLength(150).WithMessage("En fazla 150 karakter girin.");
        }
    }
}
