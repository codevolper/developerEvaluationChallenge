using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale
{
    /// <summary>
    /// Represents the validator for the CreateSaleCommand
    /// </summary>
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {
        /// <summary>
        /// Initializes a new instance of CreateSaleCommandValidator with validations
        /// </summary>
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.Id)
                .NotEmpty();

            RuleFor(sale => sale.SaleNumber)
                .NotEmpty();

            RuleForEach(x => x.Products)
                .Must(x => x.Quantity >= 0 && x.Quantity <= 20)
                .WithMessage("Each product can have a maximum of 20 items");
        }
    }
}
