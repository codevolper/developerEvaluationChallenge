using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Represents the update sale command validator.
/// </summary>
public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of UpdateSaleCommandValidator
    /// </summary>
    public UpdateSaleCommandValidator()
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
