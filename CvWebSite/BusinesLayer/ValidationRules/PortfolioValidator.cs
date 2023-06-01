using EntityLayer.Concrete;
using FluentValidation;

namespace BusinesLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator() {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Proje resmi boş geçilemez");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Proje resmi boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");

            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakterden oluşmaktadır ");

        }
    }
}
